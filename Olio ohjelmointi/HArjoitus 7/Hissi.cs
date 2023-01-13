using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HArjoitus_7
{
    internal class Hissi
    {
        public int nykyinenKerros;
        public int minKerros;
        public int maxKerros;

        public Hissi(int nykyinenKerros, int minKerros, int maxKerros)
        {
            this.nykyinenKerros = nykyinenKerros;
            this.minKerros = minKerros;
            this.maxKerros = maxKerros;
        }
        

        public void VaihdaKerrosta(int uusikerros )
        {
            nykyinenKerros = uusikerros;
            if (nykyinenKerros >maxKerros)
            {
               nykyinenKerros = maxKerros;
            }
            if (nykyinenKerros< minKerros)
            {
                nykyinenKerros = minKerros;
            }

            Console.WriteLine("hissi on kerrokseta" + nykyinenKerros);
        } 



    }
}
