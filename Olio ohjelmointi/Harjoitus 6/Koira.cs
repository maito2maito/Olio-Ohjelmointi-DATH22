using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_6
{
    internal class Koira : Eläin
    {
        public string Rotu;
        

        public Koira(string rotu , int paino , int ikä , string nimi )
        {
            this .Rotu = rotu;
            this.nimi = nimi;
            this.paino = paino;
            this.ikä = ikä;
        }

        public void TulostaTiedotkoira()
        {
            Console.WriteLine("koiran rotu on " + Rotu);
            Console.WriteLine("koiran nimi  on " + nimi);
            Console.WriteLine("koira painaa" + paino + "KG");
            Console.WriteLine("koiran ikä on" + ikä + "vuotias");



        }


    }
}
