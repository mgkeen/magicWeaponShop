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
        public void New_swords_start_with_50_magic()
        {
            var sword = new Sword();
            Assert.Equal(50, sword.MagicAmount);
        }

        [Fact]
        public void After_one_day_a_sword_loses_5_magic()
        {
            var sword = new Sword();
            sword.MidnightStrikes();
            Assert.Equal(45, sword.MagicAmount);
        }

        [Fact]
        public void A_sword_is_worth_twice_its_magic_level_in_gold()
        {
            var sword = new Sword();

            Assert.Equal(50, sword.MagicAmount);
            Assert.Equal(100, sword.Price);

            sword.MidnightStrikes();

            Assert.Equal(45, sword.MagicAmount);
            Assert.Equal(90, sword.Price);
        }
    }
}
