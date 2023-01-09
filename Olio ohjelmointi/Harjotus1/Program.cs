using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Harjotus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo mopo = new Ajoneuvo ("pv" , 4000 , 2);
            mopo.TulostaData();   

        }
    }
}
