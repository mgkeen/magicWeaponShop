using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MagicWeaponShop.Tests
{
    public class SwordTests
    {

        [Fact]
        public void NewSwordHas50Magic()
        {
            var sword = new Sword();
            Assert.Equal(Sword.InitialMagicSize, sword.Magic);
        }

        [Fact]
        public void StrikeMidnightLowersMagicBy5()
        {
            var sword = new Sword();
            sword.StrikeMidnight();
            Assert.Equal(Sword.InitialMagicSize - 5, sword.Magic);
        }

        [Fact]
        public void SellingPriceForNewSwordIsDoubleMagic()
        {
            var sword = new Sword();
            Assert.Equal(Sword.InitialMagicSize * 2, sword.SellingPrice);
        }

        [Fact]
        public void SellingPriceForNewSwordIsMagic()
        {
            var sword = GetSecondHandSword();
            Assert.Equal(Sword.InitialMagicSize / 2, sword.SellingPrice);
        }

        [Fact]
        public void SecondHandSwordHas50Magic()
        {
            var sword = GetSecondHandSword();
            Assert.Equal(Sword.InitialMagicSize / 2, sword.Magic);
        }

        private static Sword GetSecondHandSword()
        {
            var sword = new Sword();
            sword.MakeSecondHand();
            return sword;
        }
    }
}
