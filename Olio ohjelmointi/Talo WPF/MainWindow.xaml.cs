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

namespace Talo_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float lämpötila;
        bool keittiöValot;
        bool olohuoneenValot;
        bool oviLukossa;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void slider_lämpötila_ValueChanged_2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
         
        }
    }
}
