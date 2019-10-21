/*  WaterTest.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    /// <summary>
    /// All of the test cases for the Water class file
    /// </summary>
    public class WaterTest
    {
        /// <summary>
        /// Checks to see if the default price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(0.10, water.Price);
        }

        /// <summary>
        /// Checks to see if the price is correct after setting the size to small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Small;
            Assert.Equal<double>(0.10, water.Price);
        }

        /// <summary>
        /// Checks to see if the price is correct after setting the size to medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(0.10, water.Price);
        }

        /// <summary>
        /// Checks to see if the price is correct after setting the size to large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0.10, water.Price);
        }

        /// <summary>
        /// Checks to see if the default calories is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// Checks to see if the calories are correct after setting the size to small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// Checks to see if the calories are correct after setting the size to medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// Checks to see if the calories are correct after setting the size to large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// Checks to see if the default size is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }

        /// <summary>
        /// Makes sure that the default for the ice property is true
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }

        /// <summary>
        /// Makes sure that the default for the lemon property is false
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }

        /// <summary>
        /// Makes sure that the ice is held after the method is called
        /// </summary>
        [Fact]
        public void ShouldHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }

        /// <summary>
        /// Makes sure that the lemon is added after the method is called
        /// </summary>
        [Fact]
        public void ShouldAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }

        /// <summary>
        /// Checks to make sure there are the correct number and name of ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Water water = new Water();
            Assert.Contains<string>("Water", water.Ingredients);
            Assert.Equal<int>(1, water.Ingredients.Count);
        }

        /// <summary>
        /// Checks to make sure there are the correct number and name of ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredientsWithLemon()
        {
            Water water = new Water();
            Assert.Contains<string>("Water", water.Ingredients);
            Assert.Equal<int>(1, water.Ingredients.Count);
            if (water.Lemon)
            {
                Assert.Contains<string>("Lemon", water.Ingredients);
                Assert.Equal<int>(2, water.Ingredients.Count);
            }
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Water w = new Water();
            Assert.Equal($"{w.Size} Water", w.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSmall()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal($"Small Water", w.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal($"Medium Water", w.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal($"Large Water", w.Description);
        }

        [Fact]
        public void AddLemonShouldAddToSpecial()
        {
            Water w = new Water();
            w.AddLemon();
            if (w.Lemon == true)
            {
                Assert.Collection<string>(w.Special,
                    item =>
                    {
                        Assert.Equal("Add Lemon", item);
                    });
            }
        }

        [Fact]
        public void HoldingIceShouldAddToSpecial()
        {
            Water w = new Water();
            w.HoldIce();
            if (w.Ice == true)
            {
                Assert.Collection<string>(w.Special,
                    item =>
                    {
                        Assert.Equal("Hold Ice", item);
                    });
            }
        }

        [Fact]
        public void AddLemonAndHoldingIceShouldAddToSpecial()
        {
            Water w = new Water();
            w.AddLemon();
            w.HoldIce();
                Assert.Collection<string>(w.Special,
                    item =>
                    {
                        Assert.Equal("Add Lemon", item);
                    },
                    item =>
                    {
                        Assert.Equal("Hold Ice", item);
                    });
        }

        [Fact]
        public void AddingLemonShouldNotifySpecialChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Special", () =>
            {
                w.AddLemon();
            });
        }

        [Fact]
        public void AddingLemonShouldNotifyIngredientChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Ingredients", () =>
            {
                w.AddLemon();
            });
        }

        [Fact]
        public void ChangingSizeToSmallShouldNotifyCaloriesChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Calories", () =>
            {
                w.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeToMediumShouldNotifyCaloriesChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Calories", () =>
            {
                w.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeToLargeShouldNotifyCaloriesChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Calories", () =>
            {
                w.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeToSmallShouldNotifyPriceChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Price", () =>
            {
                w.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeToMediumShouldNotifyPriceChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Price", () =>
            {
                w.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeToLargeShouldNotifyPriceChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Price", () =>
            {
                w.Size = Size.Large;
            });
        }
    }
}
