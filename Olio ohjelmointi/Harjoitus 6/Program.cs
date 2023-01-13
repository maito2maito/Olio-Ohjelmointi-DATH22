using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Koira koira = new Koira ("bulldog",40 ,2 , "jorma");

            Kissa kissa = new Kissa("musta", "tiikeri", "joda", 6, 4);


            koira.TulostaTiedotkoira();

            Console.WriteLine();

            kissa.TulostaTiedotKissa();


        }
    }
}
