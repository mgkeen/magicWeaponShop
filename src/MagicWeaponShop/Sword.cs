using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWeaponShop
{
    public class Sword
    {
        public static MagicWeapon NewSword()
        {
            var priceStrategy = new MultiplierPriceCalculator(2);
            var midnightStrategy = new AdditiveMidnightStrategy(-5);
            return new MagicWeapon(50, midnightStrategy, priceStrategy);
        }

        public static MagicWeapon SecondHandSword()
        {
            var priceStrategy = new MultiplierPriceCalculator(1);
            var midnightStrategy = new AdditiveMidnightStrategy(-5);
            return new MagicWeapon(25, midnightStrategy, priceStrategy);
        }

        public static MagicWeapon DragonBloodSword(int startingMagicAmount)
        {
            var priceStrategy = new MultiplierPriceCalculator(3);
            var midnightStrategy = new AdditiveMidnightStrategy(0);
            return new MagicWeapon(startingMagicAmount, midnightStrategy, priceStrategy);
        }
    }
}
