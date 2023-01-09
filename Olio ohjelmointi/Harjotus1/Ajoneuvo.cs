using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjotus1
{
    internal class Ajoneuvo
    {
        public string Merkki;
        public int Nopeus;
        public int Renkaat;

        public Ajoneuvo(string merkki, int nopeus, int renkaat)
        {
            Merkki = merkki;
            Nopeus = nopeus;
            Renkaat = renkaat;
        }

        public void TulostaData()
        {
            Console.WriteLine("auton merkki on " + Merkki);
            Console.WriteLine("auton nopeus on " + Nopeus);
            Console.WriteLine("auton renkaat on " + Renkaat);
        }
    }
}
