namespace MagicWeaponShop
{
    internal class AdditiveMidnightStrategy : MidnightStrategy
    {
        private readonly int _magicGain;

        public AdditiveMidnightStrategy(int magicGain)
        {
            _magicGain = magicGain;
        }

        public int GetMagicAmount(MagicWeapon weapon)
        {
            return weapon.MagicAmount + _magicGain;
        }
    }
}