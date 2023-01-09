using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjotus2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        public string Nimi;
        public string OpiskelijaID;
        public int opintopisteet;

        public Program(string nimi, string opiskelijaID, int opintopisteet)
        {
            Nimi = nimi;
            OpiskelijaID = opiskelijaID;
            this.opintopisteet = opintopisteet;
        }

        public void TulostaData()
        {
            Console.WriteLine("opiskelian nimi on " + Nimi);
            Console.WriteLine("opiskelian id on " + OpiskelijaID);
            Console.WriteLine("opiskelian opintopisteet on " + opintopisteet);
        }
        
    }
    }
}
