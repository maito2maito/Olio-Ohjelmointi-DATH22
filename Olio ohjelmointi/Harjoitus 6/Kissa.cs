using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_6
{
    internal class Kissa : Eläin
    {
       
        public string Väri;
        public string Rotu;


        public Kissa(string väri, string rotu , string nimi , int paino , int ikä)
        {
            this.Väri = väri;
            this.Rotu = rotu;
            this.nimi = nimi;
            this.paino= paino;
            this.ikä = ikä;
        }

        public void TulostaTiedotKissa()
        {
            Console.WriteLine("kissan väri on " + Väri);
            Console.WriteLine("kissan rotu on " + Rotu);
            Console.WriteLine("kissan nimi  on " + nimi);
            Console.WriteLine("kissa painaa" + paino + "KG");
            Console.WriteLine("kissan ikä on" + ikä + "vuotias");



        }

    }
}
