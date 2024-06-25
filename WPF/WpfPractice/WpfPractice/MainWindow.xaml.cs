using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Media;
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

namespace WpfPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Show();
        }
    }
    public static class RoundedButtonHelper
    {
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached(
                "CornerRadius",
                typeof(CornerRadius),
                typeof(RoundedButtonHelper),
                new PropertyMetadata(new CornerRadius(), OnCornerRadiusChanged));

        public static CornerRadius GetCornerRadius(UIElement element)
        {
            return (CornerRadius)element.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(UIElement element, CornerRadius value)
        {
            element.SetValue(CornerRadiusProperty, value);
        }

        private static void OnCornerRadiusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Button button)
            {
                var cornerRadius = (CornerRadius)e.NewValue;
                button.Loaded += (s, ev) =>
                {
                    var border = VisualTreeHelper.GetChild(button, 0) as Border;
                    if (border != null)
                    {
                        border.CornerRadius = cornerRadius;
                    }
                };
            }
        }
    }

    public class ConverterTest : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;
            if(value.ToString() == "Sundar")
            {
                return true;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
