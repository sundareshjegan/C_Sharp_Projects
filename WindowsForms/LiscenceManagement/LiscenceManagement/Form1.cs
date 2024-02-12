using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;

namespace LiscenceManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            activationFileName = Path.Combine(Environment.CurrentDirectory, "ActivationFile.dat");
            saltFileName = Path.Combine(Environment.CurrentDirectory, "SaltFile.dat");
            salt = GenerateSalt();
            isLiscenceValid = CheckSystemTimeChanged();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime activated = DateTime.Parse(activatedTime);
            DateTime current = DateTime.Now;
            TimeSpan difference = current - activated;
            //isLiscenceValid = ((int)difference.TotalMinutes < activationDuration) && (CheckSystemTimeChanged());
            
            int hoursDifference = difference.Hours;
            int minutesDifference = difference.Minutes;
            int secondsDifference = difference.Seconds;

            if(activationDuration <= (int)difference.TotalMinutes && isLiscenceValid)
            {
                timer.Stop();
                MessageBox.Show("Liscence Expired..!");
                Dispose();
            }
            else
            {
                string timeLeft = $"{hoursDifference} Hours {minutesDifference} Minutes {secondsDifference} Seconds \n";
                timeLeft += "Time Left : " + (activationDuration - (int)difference.TotalMinutes) + " minutes";
                remainingTimeLabel.Text = timeLeft;
            }
        }


        private bool isLiscenceValid = false;
        private string activationFileName,saltFileName;
        private string activatedTime = "";

        private byte[] salt;
        private byte[] encryptionKey;
        private int keySize = 256;

        private int activationDuration = 130;

        private Timer timer;
        

        #region Key and Salt Generation
        public static byte[] GenerateAESKey(string passphrase, byte[] salt, int keySize)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(passphrase, salt, 10000))
            {
                return deriveBytes.GetBytes(keySize / 8);
            }
        }

        private byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16];
                rng.GetBytes(salt);
                if (File.Exists(saltFileName))
                {
                    salt = File.ReadAllBytes(saltFileName);
                }
                else
                {
                    File.WriteAllBytes(saltFileName, salt);
                }
                return salt;
            }
        }

        #endregion

        #region Encrytion and Decryption Methods
        private void EncryptDateAndTime()
        {
            DateTime currentDate = DateTime.Now;
            string dateAsString = currentDate.ToString();
            string encryptedDateAsString = EncryptString(dateAsString, encryptionKey);
            File.WriteAllText(activationFileName, encryptedDateAsString);
            label1.Text = encryptedDateAsString;
        }

        private void DecryptDateAndTime()
        {
            try
            {
                string encryptedDateAsString = File.ReadAllText(activationFileName);
                string decryptedDateAsString = DecryptString(encryptedDateAsString, encryptionKey);
                ActivatedTimeLabel.Text = decryptedDateAsString.Replace(" "," at ");
                activatedTime = decryptedDateAsString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error decrypting date and time: " + ex.Message);
            }
        }

        private string EncryptString(string plainText, byte[] key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.GenerateIV();
                byte[] ivBytes = aesAlg.IV;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, ivBytes);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    msEncrypt.Write(ivBytes, 0, ivBytes.Length);
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        private string DecryptString(string encryptedText, byte[] key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                byte[] fullCipher = Convert.FromBase64String(encryptedText);
                if (fullCipher.Length < aesAlg.BlockSize / 8 || fullCipher.Length % (aesAlg.BlockSize / 8) != 0)
                {
                    throw new ArgumentException("The encrypted text does not appear to be a valid AES cipher text.");
                }
                byte[] ivBytes = new byte[aesAlg.BlockSize / 8];
                Array.Copy(fullCipher, 0, ivBytes, 0, ivBytes.Length);
                aesAlg.IV = ivBytes;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(fullCipher, ivBytes.Length, fullCipher.Length - ivBytes.Length))
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }
        #endregion

        private void OnEncryptButtonClicked(object sender, EventArgs e)
        {
            encryptionKey = GenerateAESKey(textBox1.Text, salt, keySize);
            EncryptDateAndTime();
        }

        private void OnValidateButtonClicked(object sender, EventArgs e)
        {
            DateTime activated = DateTime.Parse(activatedTime);
            DateTime current = DateTime.Now;
            TimeSpan difference = current - activated;
            isLiscenceValid = ((int)difference.TotalMinutes < activationDuration) && (CheckSystemTimeChanged());
            if (isLiscenceValid)
            {
                timer.Start();
                MessageBox.Show("Liscence Valid..!\n Time Left : "+(activationDuration - (int)difference.TotalMinutes)+" minutes");
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Liscence Expired..!");
            }
            
        }

        private void OnDecryptButtonClicked(object sender, EventArgs e)
        {
            encryptionKey = GenerateAESKey(textBox2.Text, salt, keySize);
            DecryptDateAndTime();
        }

        private bool CheckSystemTimeChanged()
        {
            try
            {
                EventLog eventLog = new EventLog("System");
                EventLogEntryCollection entries = eventLog.Entries;
                foreach (EventLogEntry entry in entries)
                {
                    if (entry.EntryType == EventLogEntryType.Warning || entry.EntryType == EventLogEntryType.Error)
                    {
                        if (entry.Message.Contains("time zone") || entry.Message.Contains("time synchronization"))
                        {
                            isLiscenceValid = false;
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }
}
