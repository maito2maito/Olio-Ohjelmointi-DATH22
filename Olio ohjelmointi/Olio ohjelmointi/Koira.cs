using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi
{
    internal class Koira
    {
        public string nimi;
        public string Rotu;
        public int Ikä;

        public void HaeTiedot()
        {
            Console.WriteLine("Koiran nimi on" + nimi);
            Console.WriteLine("Koiran ikä on" + Ikä);
            Console.WriteLine("Koiran Rotu on" + Rotu);


        }

        public void Hauku()
        {
            Console.WriteLine(" woof woof");
        }
          
    }
}
