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
            Koira koira1 = new Koira("Rekku" , "mopsi" , 2); // luodaaan uusi koira olio/instanssi
           

            koira1.HaeTiedot();
            
            //konstruktori jolla pakotetaan olion luonti tilantessa 
            // antamaan tarvittavat tiedot oliolle (esi nimi , rotu ja ikä
            Koira koira2= new Koira("ali" , "bulldog" , 5);
           

            koira2.HaeTiedot();

            koira1.Hauku();
            koira2.Hauku();

        }
    }
}
