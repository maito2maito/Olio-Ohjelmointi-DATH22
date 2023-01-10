using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjotus4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            albumi albumi = new albumi("evolve", "imagine dragons", "poprock");


            albumi.lisääKappale(new kappale("nex to me" , "3,50"));
            albumi.TulostaTiedot();
            albumi.lisääKappale(new kappale("i dont know why" , "3,10"));
            albumi.lisääKappale(new kappale("whatevare" , "3,21"));
            albumi.lisääKappale(new kappale("beliver" , "3,24"));
            albumi.lisääKappale(new kappale("thunder" , "3,07"));


            albumi.TulostaTiedot();


        }
    }
}
