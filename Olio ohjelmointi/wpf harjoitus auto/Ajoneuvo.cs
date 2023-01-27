using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_harjoitus_auto
{
    internal class Ajoneuvo
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }
        
        public string HaeTietoja()
        {
            return Model +"ajoneuvolla on" + Tyres + "rengas ja maksiminopeus on " + Speed;
        }

    }
}
