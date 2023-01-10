using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perintä
{
    internal class player : Charakter
    {
        public int xp = 0;

        public player(int name , int helth , int damage , int level)
        {
            name = name;
            helth = helth;
            damage = damage;
            level = level;
            

        }

        public void GainXP(int XPAmount)
        {
            xp += XPAmount;

            if(xp>100)
            {
                IsDead = true;
            }
        }
    }
}
