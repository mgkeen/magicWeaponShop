namespace MagicWeaponShop
{
    public class MagicWeapon
    {
        private readonly MidnightStrategy _midnightStrategy;
        private readonly PriceCalculator _priceCalculator;

        internal MagicWeapon(int initialMagicAmount, MidnightStrategy midnightStrategy, PriceCalculator priceCalculator)
        {
            _midnightStrategy = midnightStrategy;
            _priceCalculator = priceCalculator;
            MagicAmount = initialMagicAmount;
        }

        public int MagicAmount { get; private set; }
        public int Price => _priceCalculator.GetPrice(this);

        public void MidnightStrikes()
        {
            MagicAmount = _midnightStrategy.GetMagicAmount(this);
        }
    }
}