using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWeaponShop
{
    public class Sword : ISword
    {
        public static int InitialMagicSize = 50;
        public bool IsSecondHand;
        private int _multiplier;

        public Sword()
        {
            _multiplier = 2;
            Magic = InitialMagicSize;
            IsSecondHand = false;
        }

        public int Magic { get; private set; }

        public void StrikeMidnight()
        {
            Magic = Magic - 5;
        }

        public void MakeSecondHand()
        {
            IsSecondHand = true;
            Magic = InitialMagicSize / 2;
            _multiplier = 1;
        }

        public int SellingPrice => Magic * _multiplier;
    }
}
