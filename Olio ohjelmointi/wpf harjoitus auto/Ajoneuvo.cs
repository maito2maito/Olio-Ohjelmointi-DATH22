using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_harjoitus_auto
{
    internal class Ajoneuvo
    {
        public int renkaat;
        public int nopeus;
        public string merkki;

        public Ajoneuvo(int renkaat, int nopeus, string merkki)
        {
            this.renkaat = renkaat;
            this.nopeus = nopeus;
            this.merkki = merkki;
        }
    }
}
