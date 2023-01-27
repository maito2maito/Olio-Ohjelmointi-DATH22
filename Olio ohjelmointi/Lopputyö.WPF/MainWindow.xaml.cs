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

namespace Lopputyö.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<tuote> tuotteet = new List<tuote>();

        public MainWindow()
        {
            InitializeComponent();

            // ALUSTETAAN DATA GRIDI
            dt_Data.ItemsSource =tuotteet;

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_Lisää_Click(object sender, RoutedEventArgs e)
        {
            tuote uusiTuote = new tuote();
            uusiTuote.nimi = txt_nimi.Text;
            uusiTuote.hinta = float.Parse(txt_hinta.Text);
            uusiTuote.kilohinta = float.Parse(txt_kilohinta.Text);
            uusiTuote.paino = int.Parse(txt_paino.Text);

            tuotteet.Add(uusiTuote);
            txt_nimi.Text = "";
            txt_hinta.Text = "";
            txt_kilohinta.Text = "";
            txt_paino.Text = "";

            dt_Data.Items.Refresh();
        }

     
    }
}
