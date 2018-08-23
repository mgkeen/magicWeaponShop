namespace MagicWeaponShop
{
    internal class MultiplierPriceCalculator : PriceCalculator
    {
        private readonly int _priceMultiplier;

        public MultiplierPriceCalculator(int priceMultiplier)
        {
            _priceMultiplier = priceMultiplier;
        }

        public int GetPrice(MagicWeapon weapon)
        {
            return weapon.MagicAmount * _priceMultiplier;
        }
    }
}