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

namespace toinen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int auto;
        int KuormaAuto = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bdn_Ekanappi_Click(object sender, RoutedEventArgs e)
        {
            auto++;
            txt_Ekateksti.Text="Autoja on " + auto;
        }

        private void bdn_Tokanappi_Click(object sender, RoutedEventArgs e)
        {
            KuormaAuto++;
            txt_Tokanappi.Text="Rekkoja on " + KuormaAuto;
        }
    }
}
