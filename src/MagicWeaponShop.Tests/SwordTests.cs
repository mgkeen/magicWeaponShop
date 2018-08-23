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
            var sword = Sword.NewSword();
            Assert.Equal(50, sword.MagicAmount);
        }

        [Fact]
        public void After_one_day_a_sword_loses_5_magic()
        {
            var sword = Sword.NewSword();
            sword.MidnightStrikes();
            Assert.Equal(45, sword.MagicAmount);
        }

        [Fact]
        public void A_sword_is_worth_twice_its_magic_amount_in_gold()
        {
            var sword = Sword.NewSword();

            Assert.Equal(50, sword.MagicAmount);
            Assert.Equal(100, sword.Price);

            sword.MidnightStrikes();

            Assert.Equal(45, sword.MagicAmount);
            Assert.Equal(90, sword.Price);
        }

        [Fact]
        public void Second_hand_swords_start_with_less_magic()
        {
            var sword = Sword.SecondHandSword();
            
            Assert.Equal(25, sword.MagicAmount);
        }

        [Fact]
        public void Second_hand_swords_lose_5_magic_per_day()
        {
            var sword = Sword.SecondHandSword();
            sword.MidnightStrikes();
            
            Assert.Equal(20, sword.MagicAmount);
        }

        [Fact]
        public void Second_hand_swords_sell_for_their_magic_amount_in_gold()
        {
            var sword = Sword.SecondHandSword();

            Assert.Equal(25, sword.Price);
        }
    }
}
