using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MagicWeaponShop.Tests
{
    public class TruthTests
    {
        [Fact]
        public void New_Magic_Swords_Have_50_Magic()
        {
            var newSword = new NewSword();
            Assert.Equal(50, newSword.Magic);
        }

        [Fact]
        public void When_Clock_Says_Midnight_Magic_Decreases()
        {
            var shop = new Shop(new List<MagicSword> {new NewSword(), new SecondHandSword()});

            shop.ItsMidnight();

            foreach (var s in shop.Swords)
            {
                if (s is NewSword)
                    Assert.Equal(45, s.Magic);
                else if (s is SecondHandSword)
                    Assert.Equal(20, s.Magic);

            }
        }

        [Fact]
        public void NewMagicSword_Value_Is_Doubled_Magic()
        {
            var shop = new Shop(new List<MagicSword> { new NewSword() });

            foreach (var s in shop.Swords)
                Assert.Equal(100, s.Price);
        }

        [Fact]
        public void SeconHand_Magic_Swords_Have_25_Magic()
        {
            var sword = new SecondHandSword();
            Assert.Equal(25, sword.Magic);
        }

        [Fact]
        public void SecondHandMagicSword_Value_Is_Doubled_Magic()
        {
            var shop = new Shop(new List<MagicSword> { new SecondHandSword() });

            foreach (var s in shop.Swords)
                Assert.Equal(25, s.Price);
        }
    }
}
