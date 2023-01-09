using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koira koira1 = new Koira("Rekku" , "mopsi"); // luodaaan uusi koira olio/instanssi
            koira1.nimi = "RekkuRekku";
            koira1.Ikä = 2;
            koira1.Rotu = "Mopsi";

            koira1.HaeTiedot();
            

            Koira koira2= new Koira("ali" , "bulldog");
            koira2.nimi = "ali";
            koira2.Ikä = 5;
            koira2.Rotu = "bulldog";

            koira2.HaeTiedot();

            koira1.Hauku();
            koira2.Hauku();

        }
    }
}
