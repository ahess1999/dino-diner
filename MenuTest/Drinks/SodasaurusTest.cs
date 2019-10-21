/*  SodasaurusTest.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    /// <summary>
    /// All of the test cases for the Sodasaurus class file
    /// </summary>
    public class SodasaurusTest
    {
        /// <summary>
        /// Test that tests whether or not you can set the flavor to cherry
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }

        /// <summary>
        /// Test that tests whether or not you can set the flavor to chocolate
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
        }

        /// <summary>
        /// Test that tests whether or not you can set the flavor to lime
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
        }

        /// <summary>
        /// Test that tests whether or not you can set the flavor to vanilla
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }

        /// <summary>
        /// Test that tests whether or not you can set the flavor to Root Beer
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
        }

        /// <summary>
        /// Test that tests whether or not you can set the flavor to orange
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
        }

        /// <summary>
        /// Test that tests whether or not you can set the flavor to cola
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
        }

        /// <summary>
        /// Checks to see if the default price is correct for the sodasaurus
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        /// <summary>
        /// Checks to see if the price is correct after setting the size to small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }

        /// <summary>
        /// Checks to see if the price is correct after setting the size to medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
        }

        /// <summary>
        /// Checks to see if the price is correct after setting the size to large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }

        /// <summary>
        /// Checks to see if the default calories is correct for the sodasaurus
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        /// <summary>
        /// Checks to see if the calories are correct after setting the size to small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }

        /// <summary>
        /// Checks to see if the calories are correct after setting the size to medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }

        /// <summary>
        /// Checks to see if the calories are correct after setting the size to large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }

        /// <summary>
        /// Makes sure that the default for the ice property is true
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        /// <summary>
        /// Makes sure that the ice is held after the method is called
        /// </summary>
        [Fact]
        public void ShouldHoldIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }
        
        /// <summary>
        /// Checks to make sure there are the correct number and name of ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
            Assert.Equal<int>(3, soda.Ingredients.Count);
        }

        /// <summary>
        /// Checks to see if the default size is correct for the sodasaurus
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }

        [Fact]
        public void ColaFlavorShouldChangeFlavorProperty()
        {
            Sodasaurus soda = new Sodasaurus();
            if (soda.Flavor == SodasaurusFlavor.Cola)
            {
                Assert.Collection<string>(soda.Special,
                item =>
                {
                    Assert.Equal("Cola", item);
                });
            }
        }

        [Fact]
        public void OrangeFlavorShouldChangeFlavorProperty()
        {
            Sodasaurus soda = new Sodasaurus();
            if (soda.Flavor == SodasaurusFlavor.Orange)
            {
                Assert.Collection<string>(soda.Special,
                item =>
                {
                    Assert.Equal("Orange", item);
                });
            }
        }

        [Fact]
        public void VanillaFlavorShouldChangeFlavorProperty()
        {
            Sodasaurus soda = new Sodasaurus();
            if (soda.Flavor == SodasaurusFlavor.Vanilla)
            {
                Assert.Collection<string>(soda.Special,
                item =>
                {
                    Assert.Equal("Vanilla", item);
                });
            }
        }

        [Fact]
        public void ChocolateFlavorShouldChangeFlavorProperty()
        {
            Sodasaurus soda = new Sodasaurus();
            if (soda.Flavor == SodasaurusFlavor.Chocolate)
            {
                Assert.Collection<string>(soda.Special,
                item =>
                {
                    Assert.Equal("Chocolate", item);
                });
            }
        }

        [Fact]
        public void RootBeerFlavorShouldChangeFlavorProperty()
        {
            Sodasaurus soda = new Sodasaurus();
            if (soda.Flavor == SodasaurusFlavor.RootBeer)
            {
                Assert.Collection<string>(soda.Special,
                item =>
                {
                    Assert.Equal("Root Beer", item);
                });
            }
        }

        [Fact]
        public void CherryFlavorShouldChangeFlavorProperty()
        {
            Sodasaurus soda = new Sodasaurus();
            if (soda.Flavor == SodasaurusFlavor.Cherry)
            {
                Assert.Collection<string>(soda.Special,
                item =>
                {
                    Assert.Equal("Cherry", item);
                });
            }
        }

        [Fact]
        public void LimeFlavorShouldChangeFlavorProperty()
        {
            Sodasaurus soda = new Sodasaurus();
            if (soda.Flavor == SodasaurusFlavor.Lime)
            {
                Assert.Collection<string>(soda.Special,
                item =>
                {
                    Assert.Equal("Lime", item);
                });
            }
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal($"{soda.Size} {soda.Flavor} Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            Assert.Equal($"Small {soda.Flavor} Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal($"Medium {soda.Flavor} Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal($"Large {soda.Flavor} Sodasaurus", soda.Description);
        }

        [Fact]
        public void ChangingSizeToSmallShouldNotifyCaloriesChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeToMediumShouldNotifyCaloriesChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeToLargeShouldNotifyCaloriesChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Large;
            });
        }

        [Fact]
        public void HoldingIceShouldAddToSpecial()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            if (soda.Ice == true)
            {
                Assert.Collection<string>(soda.Special,
                    item =>
                    {
                        Assert.Equal("Hold Ice", item);
                    });
            }
        }

        
    }
}
