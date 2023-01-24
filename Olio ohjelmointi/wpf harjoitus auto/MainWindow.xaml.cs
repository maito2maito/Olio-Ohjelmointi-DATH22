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

namespace wpf_harjoitus_auto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
            List<Ajoneuvo> ajoneuvot = new List<Ajoneuvo>();
        public MainWindow()
        {

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   //luodaan uusia ajoneuvo olio
            Ajoneuvo uusiAjoneuvo = new Ajoneuvo();

            uusiAjoneuvo.Model = input_Malli.Text;
            uusiAjoneuvo.Speed = int.Parse(input_Nopeus.Text);
            uusiAjoneuvo.Tyres = int.Parse(input_Renkaat.Text);

            input_Malli.Text = input_Malli.Text;
            input_Renkaat.Text = "";
            input_Nopeus.Text = "";

            txt_luotuajoneuvo.Text = "luotu uusi ajoneuvo tiedoilla: \n" + uusiAjoneuvo.HaeTietoja();
            ajoneuvot.Add(uusiAjoneuvo);
            



        }
    }
}
