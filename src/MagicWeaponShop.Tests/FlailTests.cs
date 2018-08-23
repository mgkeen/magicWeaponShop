using Xunit;

namespace MagicWeaponShop.Tests
{
    public class FlailTests
    {
        [Fact]
        public void Fresh_flails_have_0_magic()
        {
            var flail = Flail.NewFlail();

            Assert.Equal(0, flail.MagicAmount);
        }

        [Fact]
        public void Fresh_flails_gain_1_magic_per_day()
        {
            var flail = Flail.NewFlail();

            flail.MidnightStrikes();

            Assert.Equal(1, flail.MagicAmount);
        }

        [Fact]
        public void Fresh_flails_cost_25_plus_their_magic_level()
        {
            var flail = Flail.NewFlail();

            flail.MidnightStrikes();

            Assert.Equal(26, flail.Price);
        }

        [Fact]
        public void Second_hand_flails_have_a_magic_level_according_to_their_age()
        {
            var ageInDays = 5;
            var flail = Flail.SecondHandFlail(ageInDays);

            Assert.Equal(ageInDays, flail.MagicAmount);
        }

        [Fact]
        public void Flails_with_dragon_blood_gain_2_magic_per_day()
        {
            var flail = Flail.SecondHandFlail(0, true);

            flail.MidnightStrikes();

            Assert.Equal(2, flail.MagicAmount);
        }

        [Fact]
        public void Flails_with_dragon_blood_cost_50_plus_their_magic_level()
        {
            var flail = Flail.SecondHandFlail(5, true);

            flail.MidnightStrikes();

            Assert.Equal(57, flail.Price);
        }
    }
}