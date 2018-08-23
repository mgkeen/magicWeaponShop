using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWeaponShop
{
    public class Sword
    {
        private readonly int _priceMultiplier;

        internal Sword(int startingMagicAmount, int priceMultiplier)
        {
            _priceMultiplier = priceMultiplier;
            MagicAmount = startingMagicAmount;
        }

        public int MagicAmount { get; private set; }
        public int Price => MagicAmount * _priceMultiplier;

        public void MidnightStrikes()
        {
            MagicAmount = MagicAmount - 5;
        }

        public static Sword NewSword()
        {
            return new Sword(50, 2);
        }

        public static Sword SecondHandSword()
        {
            return new Sword(25, 1);
        }
    }
}
