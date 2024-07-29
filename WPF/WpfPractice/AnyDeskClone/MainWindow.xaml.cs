using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnyDeskClone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private TcpClient client;
        private NetworkStream stream;
        private bool isConnected = false;

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isConnected)
            {
                Task.Run(() => ConnectToServer());
            }
        }

        private async Task ConnectToServer()
        {
            try
            {
                client = new TcpClient("192.168.3.201", 8000);
                stream = client.GetStream();
                isConnected = true;
                Dispatcher.Invoke(() => MessageBox.Show("Connected to server"));

                while (isConnected)
                {
                    try
                    {
                        // Read the image data length from the stream (assuming length is sent as an int before image data)
                        byte[] lengthBuffer = new byte[4];
                        await stream.ReadAsync(lengthBuffer, 0, 4);
                        int imageLength = BitConverter.ToInt32(lengthBuffer, 0);

                        // Read the actual image data
                        byte[] imageData = new byte[imageLength];
                        int bytesRead = 0;
                        while (bytesRead < imageLength)
                        {
                            bytesRead += await stream.ReadAsync(imageData, bytesRead, imageLength - bytesRead);
                        }

                        // Create the BitmapImage from the received image data
                        using (MemoryStream memoryStream = new MemoryStream(imageData))
                        {
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.CacheOption = BitmapCacheOption.OnLoad;
                            bitmap.StreamSource = memoryStream;
                            bitmap.EndInit();
                            bitmap.Freeze(); // Freeze the BitmapImage to make it cross-thread accessible

                            // Update the UI on the UI thread
                            Dispatcher.Invoke(() =>
                            {
                                ScreenImage.Source = bitmap;
                            });
                        }
                    }
                    catch (IOException ex) when (ex.InnerException is SocketException socketEx &&
                                                    (socketEx.SocketErrorCode == SocketError.ConnectionReset ||
                                                     socketEx.SocketErrorCode == SocketError.ConnectionAborted))
                    {
                        Dispatcher.Invoke(() =>
                        {
                            MessageBox.Show("Connection to the server was lost: " + ex.Message);
                        });
                        isConnected = false;
                    }
                    catch (Exception ex)
                    {
                        Dispatcher.Invoke(() =>
                        {
                            MessageBox.Show("Error receiving image data: " + ex.Message);
                        });
                        isConnected = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Dispatcher.Invoke(() =>
                {
                    MessageBox.Show("Error connecting to server: " + ex.Message);
                });
                isConnected = false;
            }
        }

        private void ScreenImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (isConnected)
            {
                Point position = e.GetPosition(ScreenImage);
                SendMouseEvent(position, "MouseDown");
            }
        }

        private void ScreenImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (isConnected && e.LeftButton == MouseButtonState.Pressed)
            {
                Point position = e.GetPosition(ScreenImage);
                SendMouseEvent(position, "MouseMove");
            }
        }

        private void ScreenImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (isConnected)
            {
                Point position = e.GetPosition(ScreenImage);
                SendMouseEvent(position, "MouseUp");
            }
        }

        private void SendMouseEvent(Point position, string eventType)
        {
            if (client != null && client.Connected)
            {
                NetworkStream stream = client.GetStream();
                StreamWriter writer = new StreamWriter(stream);

                // Get the client's screen resolution
                double screenWidth = SystemParameters.PrimaryScreenWidth;
                double screenHeight = SystemParameters.PrimaryScreenHeight;

                writer.WriteLine($"{eventType}:{(position.X / ScreenImage.ActualWidth) * screenWidth},{(position.Y / ScreenImage.ActualHeight) * screenHeight}:{screenWidth},{screenHeight}");
                writer.Flush();
            }
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            SendKeyEvent(e.Key, "KeyDown");
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            SendKeyEvent(e.Key, "KeyUp");
        }

        private void SendKeyEvent(Key key, string eventType)
        {
            if (client != null && client.Connected)
            {
                NetworkStream stream = client.GetStream();
                StreamWriter writer = new StreamWriter(stream);

                // Convert Key to virtual key code
                byte virtualKeyCode = (byte)KeyInterop.VirtualKeyFromKey(key);

                // Get the client's screen resolution
                double screenWidth = SystemParameters.PrimaryScreenWidth;
                double screenHeight = SystemParameters.PrimaryScreenHeight;

                // Send the event to the server
                writer.WriteLine($"{eventType}:{0},{0}:{screenWidth}:{screenHeight}:{virtualKeyCode}");
                writer.Flush();
            }
        }

    }
}

