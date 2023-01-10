using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perintä
{
    abstract class Charakter
    {
        public string Name;
        public int helth;
        public int Damage;
        public int Level;
        public bool IsDead = false;


        //jos hahmo on kuolut ei voi ottaa damagea 
        public void TakeDamage(Charakter damageDealer)
        {
            if (helth > 0)
            {
                IsDead= true;


            }
        }

    }
}
