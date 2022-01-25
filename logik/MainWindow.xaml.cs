using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace logik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush barva1;
        Brush barva2;
        Brush barva3;
        Brush barva4;

        public MainWindow()
        {
            InitializeComponent();
            NastavitVariantu0();
            nastavbarvypc();
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
            else
            {
                ellipse.Fill = Brushes.Red;
            }
        }
        private void nastavelipsudisable(Ellipse ellipse)
        {
            ellipse.IsEnabled = false;
            ellipse.Fill = Brushes.White;
            ellipse.Stroke = Brushes.Gray;
        }
        private void nastavelipsuenable(Ellipse ellipse)
        {
            ellipse.IsEnabled = true;
            ellipse.Fill = Brushes.LightGray;
            ellipse.Stroke = Brushes.Black;
            ellipse.Cursor = Cursors.Hand;
        }
        private void NastavitVariantu0()
        {
            nastavelipsuenable(ellipse_0_0);
            nastavelipsuenable(ellipse_0_1);
            nastavelipsuenable(ellipse_0_2);
            nastavelipsuenable(ellipse_0_3);

            nastavelipsudisable(ellipse_1_0);
            nastavelipsudisable(ellipse_1_1);
            nastavelipsudisable(ellipse_1_2);
            nastavelipsudisable(ellipse_1_3);

            nastavelipsudisable(ellipse_2_0);
            nastavelipsudisable(ellipse_2_1);
            nastavelipsudisable(ellipse_2_2);
            nastavelipsudisable(ellipse_2_3);

            nastavelipsudisable(ellipse_3_0);
            nastavelipsudisable(ellipse_3_1);
            nastavelipsudisable(ellipse_3_2);
            nastavelipsudisable(ellipse_3_3);

            nastavelipsudisable(ellipse_4_0);
            nastavelipsudisable(ellipse_4_1);
            nastavelipsudisable(ellipse_4_2);
            nastavelipsudisable(ellipse_4_3);

            nastavelipsudisable(ellipse_5_0);
            nastavelipsudisable(ellipse_5_1);
            nastavelipsudisable(ellipse_5_2);
            nastavelipsudisable(ellipse_5_3);

            nastavelipsudisable(ellipse_6_0);
            nastavelipsudisable(ellipse_6_1);
            nastavelipsudisable(ellipse_6_2);
            nastavelipsudisable(ellipse_6_3);

            nastavelipsudisable(ellipse_7_0);
            nastavelipsudisable(ellipse_7_1);
            nastavelipsudisable(ellipse_7_2);
            nastavelipsudisable(ellipse_7_3);

            nastavelipsudisable(ellipse_8_0);
            nastavelipsudisable(ellipse_8_1);
            nastavelipsudisable(ellipse_8_2);
            nastavelipsudisable(ellipse_8_3);
        }
        private void nastavbarvypc()
        {
            barva1 = ziskejbarvu();
            barva2 = ziskejbarvu();
            barva3 = ziskejbarvu();
            barva4 = ziskejbarvu();

        }
        private Brush ziskejbarvu()
        {
            Random random = new Random();
            int cislo = random.Next(1, 7);
            if (cislo == 1)
            {
                return Brushes.Red;
            }
            else if (cislo == 2)
            {
                return Brushes.Green;
            }
            else if (cislo == 3)
            {
                return Brushes.Blue;
            }
            else if (cislo == 4)
            {
                return Brushes.Yellow;
            }
            else if (cislo == 5)
            {
                return Brushes.Orange;
            }
            else if (cislo == 6)
            {
                return Brushes.Purple;
            }
            return Brushes.Red;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //1. varianta
            int pocetcernych = 0;
            if (ellipse_0_0.Fill == barva1)
            {
                pocetcernych++;
            }
            if (ellipse_0_1.Fill == barva2)
            {
                pocetcernych++;
            }
            if (ellipse_0_2.Fill == barva3)
            {
                pocetcernych++;
            }
            if (ellipse_0_3.Fill == barva4)
            {
                pocetcernych++;
            }
            if (pocetcernych > 0)
            {
                rectangle_0_0.Fill = Brushes.Black;
            }
            if (pocetcernych > 1)
            {
                rectangle_0_1.Fill = Brushes.Black;
            }
            if (pocetcernych > 2)
            {
                rectangle_0_2.Fill = Brushes.Black;
            }
            if (pocetcernych > 3)
            {
                rectangle_0_3.Fill = Brushes.Black;
                MessageBox.Show("win");
            }
        }
    }
}
