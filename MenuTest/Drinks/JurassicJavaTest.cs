/*  JurassicJavaTest.cs
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
    /// All of the test cases for the JurassicJava class file
    /// </summary>
    public class JurassicJavaTest
    {
        /// <summary>
        /// Checks to see if the default price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(0.59, java.Price);
        }

        /// <summary>
        /// Checks to see if the price is correct after setting the size to small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal<double>(0.59, java.Price);
        }

        /// <summary>
        /// Checks to see if the price is correct after setting the size to medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(0.99, java.Price);
        }

        /// <summary>
        /// Checks to see if the price is correct after setting the size to large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }

        /// <summary>
        /// Checks to see if the default calories is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        /// <summary>
        /// Checks to see if the calories are correct after setting the size to small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }

        /// <summary>
        /// Checks to see if the calories are correct after setting the size to medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        /// <summary>
        /// Checks to see if the calories are correct after setting the size to large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        /// <summary>
        /// Makes sure that the ice is added after the method is called
        /// </summary>
        [Fact]
        public void ShouldAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        /// <summary>
        /// Makes sure that the cream is added after the method is called
        /// </summary>
        [Fact]
        public void ShouldAddCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveSpaceForCream();
            Assert.True(java.SpaceForCream);
        }

        /// <summary>
        /// Checks to see if the default size is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        /// <summary>
        /// Makes sure that the default for the ice property is true
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        /// <summary>
        /// Makes sure that the default for the SpaceForCream property is true
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.SpaceForCream);
        }

        /// <summary>
        /// Checks to make sure there are the correct number and name of ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal<int>(2, java.Ingredients.Count);
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal($"{java.Size} Jurassic Java", java.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForDecaf()
        {
            JurassicJava java = new JurassicJava();
            java.Decaf = true;
            Assert.Equal($"{java.Size} Decaf Jurassic Java", java.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal($"Small Jurassic Java", java.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal($"Medium Jurassic Java", java.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal($"Large Jurassic Java", java.Description);
        }

        [Fact]
        public void HoldCreamShouldAddToSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveSpaceForCream();
            if (java.SpaceForCream == false)
            {
                Assert.Collection<string>(java.Special,
                    item =>
                    {
                        Assert.Equal("Hold Cream", item);
                    });
            }
        }

        [Fact]
        public void AddIceShouldAddToSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            java.SpaceForCream = true;
            if (java.Ice == true)
            {
                Assert.Collection<string>(java.Special,
                    item =>
                    {
                        Assert.Equal("Add Ice", item);
                    });
            }
        }

        [Fact]
        public void HoldCreamAndAddIceShouldAddToSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            java.LeaveSpaceForCream();
            if (java.SpaceForCream == false && java.Ice == false)
            {
                Assert.Collection<string>(java.Special,
                    item =>
                    {
                        Assert.Equal($"{java.Size}", item);
                    },
                    item =>
                    {
                        Assert.Equal("Hold Cream", item);
                    },
                    item =>
                    {
                        Assert.Equal("Hold Ice", item);
                    });
            }
        }

        [Fact]
        public void HoldingCreamShouldNotifySpecialChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.LeaveSpaceForCream();
            });
        }

        [Fact]
        public void AddingIceShouldNotifySpecialChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.AddIce();
            });
        }

        [Fact]
        public void HoldingCreamShouldNotifyIngredientChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Ingredients", () =>
            {
                java.LeaveSpaceForCream();
            });
        }

        [Fact]
        public void AddingIceShouldNotifyIngredientChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Ingredients", () =>
            {
                java.AddIce();
            });
        }

        [Fact]
        public void ChangingSizeToSmallShouldNotifyCaloriesChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Calories", () =>
            {
                java.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeToMediumShouldNotifyCaloriesChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Calories", () =>
            {
                java.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeToLargeShouldNotifyCaloriesChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Calories", () =>
            {
                java.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeToSmallShouldNotifyPriceChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeToMediumShouldNotifyPriceChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeToLargeShouldNotifyPriceChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = Size.Large;
            });
        }
    }
}
