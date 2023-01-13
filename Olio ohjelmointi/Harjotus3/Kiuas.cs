using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Harjotus3
{
    internal class Kiuas
    {
        public bool onkopäälä;
        public int lämpötila;
        public int kosteus;

        public void Kiuvaspääle()
        {
         onkopäälä= true;
            Console.WriteLine("kiuvas on päälä");
        }
        public void Kiuvaspois()
        {
            onkopäälä = false;
            Console.WriteLine("kiuvas ei ole päälä");
        }
        public void Muutalämpötilaa(int uusilämpötila ) 
        {
        if(onkopäälä)
            {
                lämpötila = uusilämpötila;
                Console.WriteLine("saunan lämpötila on " + lämpötila);
            }
        }
        public void Muutakosteutta(int uusikosteus )
        {
            if (onkopäälä)
            {
                kosteus = uusikosteus;
                Console.WriteLine("saunan kosteus on " + kosteus);
            }
        }



    }
}
