using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjotus2
{
    internal class Opiskelija
    {
        public string Nimi;
        public string OpiskelijaID;
        public int opintopisteet;

        public Opiskelija(string nimi, string opiskelijaID, int opintopisteet)
        {
            Nimi = nimi;
            OpiskelijaID = opiskelijaID;
            this.opintopisteet = opintopisteet;
        }

        public void TulostaData()
        {
            Console.WriteLine("opiskelian nimi on " + Nimi);
            Console.WriteLine("opiskelian id on " + OpiskelijaID);
            Console.WriteLine("opiskelian oi on " + opintopisteet);
        }
        public void Muokaaopintopisteitä(int määrä) 
        {
            opintopisteet += määrä;
        }
    }
}
