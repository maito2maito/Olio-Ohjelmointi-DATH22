using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjotus4
{
    internal class albumi
    {
        public string albuminNimi;
        public string artisti;
        public string genre;

        //yksityinen lista kappale olioista joita voidaan käsitellä vain tämän 
        //luokan sisällä 
        private List<kappale> kappaleet = new List<kappale>();

        public albumi(string albuminNimi, string artisti, string genre)
        {
            this.albuminNimi = albuminNimi;
            this.artisti = artisti;
            this.genre = genre;
        }
        
        //metodi jolla lisätään kappaleet listaan uusia kappaleita 
        public void lisääKappale(kappale uusikappale)
        {
            //lisätään listaan uusi kappale parametri arvosta
         kappaleet.Add(uusikappale);
        }

        public void TulostaTiedot()
        {
            Console.WriteLine();
            Console.WriteLine("albumi:");
            Console.WriteLine("-artistit: " + artisti);
            Console.WriteLine("-albumin nimi: " + albuminNimi);
            Console.WriteLine("-GENRE: " + genre);
            Console.WriteLine("songs");


            //tulostetaan jokaisen kappaleen tiedot consoleen 
            foreach (kappale kappale in kappaleet)
            {
                kappale.TulostaTiedot();
            }
        }



    }
}
