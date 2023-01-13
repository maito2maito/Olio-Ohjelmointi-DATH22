using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjotus3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kiuas kiuas = new Kiuas();

            kiuas.Kiuvaspääle();
            kiuas.Muutakosteutta(1);
            kiuas.Muutalämpötilaa(9);

        }
    }
}
