﻿using System;
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
            Opiskelija opiskelia1 = new Opiskelija("pertti", "careeria",180);
            opiskelia1.TulostaData();
            opiskelia1.Muokaaopintopisteitä(5);
            opiskelia1.TulostaData();
        }
    }
}
