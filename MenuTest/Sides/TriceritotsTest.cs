using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class TriceritotsTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal(0.99, tt.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal<uint>(352, tt.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Triceritots tt = new Triceritots();
            Assert.Contains<string>("Potato", tt.Ingredients);
            Assert.Contains<string>("Salt", tt.Ingredients);
            Assert.Contains<string>("Vegetable Oil", tt.Ingredients);
            Assert.Equal<int>(3, tt.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal<Size>(Size.Small, tt.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal(1.45, tt.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal<uint>(410, tt.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, tt.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal(1.95, tt.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal<uint>(590, tt.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, tt.Size);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSmall()
        {
            Triceritots t = new Triceritots();
            t.Size = Size.Small;
            Assert.Equal("Small Triceritots", t.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMedium()
        {
            Triceritots t = new Triceritots();
            t.Size = Size.Medium;
            Assert.Equal("Medium Triceritots", t.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLarge()
        {
            Triceritots t = new Triceritots();
            t.Size = Size.Large;
            Assert.Equal("Large Triceritots", t.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Triceritots t = new Triceritots();
            Assert.Empty(t.Special);
        }

        [Fact]
        public void ChangingSizeToSmallShouldNotifyCaloriesChange()
        {
            Triceritots t = new Triceritots();
            Assert.PropertyChanged(t, "Calories", () =>
            {
                t.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeToMediumShouldNotifyCaloriesChange()
        {
            Triceritots t = new Triceritots();
            Assert.PropertyChanged(t, "Calories", () =>
            {
                t.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeToLargeShouldNotifyCaloriesChange()
        {
            Triceritots t = new Triceritots();
            Assert.PropertyChanged(t, "Calories", () =>
            {
                t.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeToSmallShouldNotifyPriceChange()
        {
            Triceritots t = new Triceritots();
            Assert.PropertyChanged(t, "Price", () =>
            {
                t.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeToMediumShouldNotifyPriceChange()
        {
            Triceritots t = new Triceritots();
            Assert.PropertyChanged(t, "Price", () =>
            {
                t.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeToLargeShouldNotifyPriceChange()
        {
            Triceritots t = new Triceritots();
            Assert.PropertyChanged(t, "Price", () =>
            {
                t.Size = Size.Large;
            });
        }
    }
}
