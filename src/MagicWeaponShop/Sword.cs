using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWeaponShop
{
    public class Sword
    {
        public Sword()
        {
            MagicAmount = 50;
        }

        public int MagicAmount { get; private set; }
        public int Price => MagicAmount * 2;

        public void MidnightStrikes()
        {
            MagicAmount = MagicAmount - 5;
        }
    }
}
