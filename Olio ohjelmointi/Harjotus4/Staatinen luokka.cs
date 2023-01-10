using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjotus4
{

    //static sanalla luodaan staatinen globaali luokka josta ei tarvitse tehä olita
    static class Staatinen_luokka
    {
        public static void staattinenMetodi()
        {
            Console.WriteLine("tämä on staatinen metodi");

        }

        public static float KmToMiles(float km)
        {
            float conversionRate = 0,62137f;
            return km * conversionRate;
        }
    }
}
