namespace MagicWeaponShop
{
    public class Flail
    {
        public static MagicWeapon SecondHandFlail(int ageInDays, bool hasDragonBlood = false)
        {
            var midnightStrategy = hasDragonBlood ? new AdditiveMidnightStrategy(2) : new AdditiveMidnightStrategy(1);
            var priceStrategy = hasDragonBlood ? new FixedPlusMagicPriceCalculator(50) : new FixedPlusMagicPriceCalculator(25);
            return new MagicWeapon(ageInDays, midnightStrategy, priceStrategy);
        }

        public static MagicWeapon NewFlail()
        {
            return new MagicWeapon(0, new AdditiveMidnightStrategy(1), new FixedPlusMagicPriceCalculator(25));
        }
    }
}