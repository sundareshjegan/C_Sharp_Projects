using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfPractice.UserControls
{
    /// <summary>
    /// Interaction logic for CustomTextBox.xaml
    /// </summary>
    public partial class CustomTextBox : UserControl
    {
        private bool isEllipseOnRight = false;
        public CustomTextBox()
        {
            InitializeComponent();
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            double newLeft = isEllipseOnRight ? 0 : border.Width - ellipse.Width;    
            DoubleAnimation moveAnimation = new DoubleAnimation
            {
                To = newLeft,
                Duration = TimeSpan.FromSeconds(0.5)
            };

            ellipse.BeginAnimation(Canvas.LeftProperty, moveAnimation);
            isEllipseOnRight = !isEllipseOnRight;
        }
    }
}
