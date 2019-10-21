using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Brontowurst b = new Brontowurst();
            Assert.Equal("Brontowurst", b.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Brontowurst b = new Brontowurst();
            Assert.Empty(b.Special);
        }

        [Fact]
        public void HoldBunShouldAddToSpecial()
        {
            Brontowurst b = new Brontowurst();
            b.HoldBun();
            Assert.Collection<string>(b.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                });
        }

        [Fact]
        public void HoldOnionShouldAddToSpecial()
        {
            Brontowurst b = new Brontowurst();
            b.HoldOnion();
            Assert.Collection<string>(b.Special,
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                });
        }

        [Fact]
        public void HoldPeppersShouldAddToSpecial()
        {
            Brontowurst b = new Brontowurst();
            b.HoldPeppers();
            Assert.Collection<string>(b.Special,
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                });
        }

        [Fact]
        public void HoldBunAndOnionsAndPeppersShouldAddToSpecial()
        {
            Brontowurst b = new Brontowurst();
            b.HoldBun();
            b.HoldPeppers();
            b.HoldOnion();
            Assert.Collection<string>(b.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                });
        }

        [Fact]
        public void HoldingBunShouldNotifySpecialChange()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldBun();
            });
        }

        [Fact]
        public void HoldingOnionShouldNotifySpecialChange()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldOnion();
            });
        }

        [Fact]
        public void HoldingPeppersShouldNotifySpecialChange()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldPeppers();
            });
        }

        [Fact]
        public void HoldingBunShouldNotifyIngredientChange()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Ingredients", () =>
            {
                b.HoldBun();
            });
        }

        [Fact]
        public void HoldingOnionShouldNotifyIngredientChange()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Ingredients", () =>
            {
                b.HoldOnion();
            });
        }

        [Fact]
        public void HoldingPeppersShouldNotifyIngredientChange()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Ingredients", () =>
            {
                b.HoldPeppers();
            });
        }
    }
}
