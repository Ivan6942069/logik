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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace logik
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

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse ellipse = (Ellipse)sender;

            if (ellipse.Fill.ToString() == "#FFFFFFFF")
            {
                ellipse.Fill = Brushes.Red;
            }
            
            else if (ellipse.Fill == Brushes.Red)
            {
                ellipse.Fill = Brushes.Green;
            }
            else if (ellipse.Fill == Brushes.Green)
            {
                ellipse.Fill = Brushes.Blue;
            }
            else if (ellipse.Fill == Brushes.Blue)
            {
                ellipse.Fill = Brushes.Yellow;
            }
            else if (ellipse.Fill == Brushes.Yellow)
            {
                ellipse.Fill = Brushes.Orange;
            }
            else if (ellipse.Fill == Brushes.Orange)
            {
                ellipse.Fill = Brushes.Purple;
            }
            else if (ellipse.Fill == Brushes.Purple)
            {
                ellipse.Fill = Brushes.Red;
            } 
        }
        private void NastavitVariantu0(bool aktivni)
        {
            if(aktivni)
            {
                ellipse_0_0.MouseDown += Ellipse_MouseDown;
            }
            else
            {
                ellipse_0_0.MouseDown -= Ellipse_MouseDown;
            }
        }
    }
}
