﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HArjoitus_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi(1,1, 7);
            hissi.VaihdaKerrosta(2);
            hissi.VaihdaKerrosta(-500);
            hissi.VaihdaKerrosta(-100);
            hissi.VaihdaKerrosta(5);
            hissi.VaihdaKerrosta(10);
                

           
            
          


        }
    }
}
