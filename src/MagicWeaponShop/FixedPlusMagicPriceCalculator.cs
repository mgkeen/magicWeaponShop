namespace MagicWeaponShop
{
    internal class FixedPlusMagicPriceCalculator : PriceCalculator
    {
        private readonly int _fixedStartingPoint;

        public FixedPlusMagicPriceCalculator(int fixedStartingPoint)
        {
            _fixedStartingPoint = fixedStartingPoint;
        }

        public int GetPrice(MagicWeapon weapon)
        {
            return _fixedStartingPoint + weapon.MagicAmount;
        }
    }
}