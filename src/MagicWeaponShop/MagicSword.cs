using System;
using System.Collections.Generic;

namespace MagicWeaponShop
{
    public class Shop
    {
        public Shop(List<MagicSword> swords)
        {
            Swords = swords;
        }

        public List<MagicSword> Swords { get; }

        public void ItsMidnight()
        {
            foreach (var s in Swords)
                s.Degrade();

        }
    }

    public abstract class MagicSword
    {
        private readonly Func<int, int> _priceCalculator;

        protected MagicSword(int initialMagic, Func<int, int> priceCalculator)
        {
            Magic = initialMagic;
            _priceCalculator = priceCalculator;
        }

        public int Magic { get; private set; }
        public int Price => _priceCalculator(Magic);

        public void Degrade()
        {
            Magic -= 5;
        }
    }

    public class NewSword : MagicSword
    {
        public NewSword() : base(50, x => x * 2)
        {
            
        }
    }

    public class SecondHandSword : MagicSword
    {
        public SecondHandSword() : base(25, x => x)
        {

        }
    }

}