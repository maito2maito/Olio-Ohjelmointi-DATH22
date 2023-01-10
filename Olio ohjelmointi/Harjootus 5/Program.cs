using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjootus_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Laskin.summa(15, 2));
            Console.WriteLine(Laskin.erotus(15, 2));
            Console.WriteLine(Laskin.kertolasku(15, 2));
            Console.WriteLine(Laskin.jako(15, 2));
        }
    }
}
