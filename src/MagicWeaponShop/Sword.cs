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
        private readonly int _magicLossRate;

        internal Sword(int startingMagicAmount, int priceMultiplier, int magicLossRate)
        {
            _priceMultiplier = priceMultiplier;
            _magicLossRate = magicLossRate;
            MagicAmount = startingMagicAmount;
        }

        public int MagicAmount { get; private set; }
        public int Price => MagicAmount * _priceMultiplier;

        public void MidnightStrikes()
        {
            MagicAmount = MagicAmount - _magicLossRate;
        }

        public static Sword NewSword()
        {
            return new Sword(50, 2, 5);
        }

        public static Sword SecondHandSword()
        {
            return new Sword(25, 1, 5);
        }

        public static Sword DragonBloodSword(int startingMagicAmount)
        {
            return new Sword(startingMagicAmount, 3, 0);
        }
    }
}
