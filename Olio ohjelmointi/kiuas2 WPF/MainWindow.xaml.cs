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

namespace kiuas2_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            slider_Kosteus.IsEnabled = false;
            slider_lämpötila.IsEnabled = false;
        }

        private void ckb1_Checked(object sender, RoutedEventArgs e)
        {
            slider_Kosteus.IsEnabled = true;
            slider_lämpötila.IsEnabled = true;

        }



        private void slider_Kosteus_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txb_k.Text = "Kosteus:" + slider_Kosteus.Value;
        }

        private void slider_lämpötila_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txt_L.Text = "Lämpötila:" + slider_lämpötila.Value;
        }

        private void ckb1_Unchecked(object sender, RoutedEventArgs e)
        {
            slider_Kosteus.IsEnabled = false;
            slider_lämpötila.IsEnabled = false;

        }


    }
}

