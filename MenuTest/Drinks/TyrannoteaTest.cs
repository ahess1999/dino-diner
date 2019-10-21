/*  TyrannoteaTest.cs
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
    /// All of the test cases for the Tyrannotea class file
    /// </summary>
    public class TyrannoteaTest
    {
        /// <summary>
        /// Checks to see if the default price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        /// <summary>
        /// Checks to see if the price is correct after setting the size to small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }

        /// <summary>
        /// Checks to see if the price is correct after setting the size to medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }

        /// <summary>
        /// Checks to see if the price is correct after setting the size to large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }

        /// <summary>
        /// Checks to see if the default calories is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// Checks to see if the calories are correct after setting the size to small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// Checks to see if the calories are correct after setting the size to medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// Checks to see if the calories are correct after setting the size to large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        /// <summary>
        /// Checks to see if the default size is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        /// <summary>
        /// Makes sure that the default for the sweet property is false
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }

        /// <summary>
        /// Makes sure that the default for the ice property is true
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        /// <summary>
        /// Makes sure that the default for the lemon property is true
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }

        /// <summary>
        /// Makes sure that the ice is held after the method is called
        /// </summary>
        [Fact]
        public void ShouldHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        /// <summary>
        /// Makes sure that the lemon is added after the method is called
        /// </summary>
        [Fact]
        public void ShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        /// <summary>
        /// Checks to make sure the calories are correct after adding sweetner
        /// </summary>
        [Fact]
        public void AddingSweetnerShouldDoubleCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            if (tea.Sweet)
            {
                Assert.Equal<uint>(16, tea.Calories);
            }
        }

        /// <summary>
        /// Checks to make sure the calories are correct after adding sweetner
        /// </summary>
        [Fact]
        public void AddingSweetnerShouldDoubleCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            if (tea.Sweet)
            {
                Assert.Equal<uint>(32, tea.Calories);
            }
        }

        /// <summary>
        /// Checks to make sure the calories are correct after adding sweetner
        /// </summary>
        [Fact]
        public void AddingSweetnerShouldDoubleCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            if (tea.Sweet)
            {
                Assert.Equal<uint>(64, tea.Calories);
            }
        }

        /// <summary>
        /// Checks to make sure the calories are correct after removing sweetner
        /// </summary>
        [Fact]
        public void RemovingSweetnerShouldReturnToDefaultCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.AddSweetner();
            tea.RemoveSweetner();
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// Checks to make sure the calories are correct after removing sweetner
        /// </summary>
        [Fact]
        public void RemovingSweetnerShouldReturnToDefaultCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.AddSweetner();
            tea.RemoveSweetner();
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// Checks to make sure the calories are correct after removing sweetner
        /// </summary>
        [Fact]
        public void RemovingSweetnerShouldReturnToDefaultCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.AddSweetner();
            tea.RemoveSweetner();
            Assert.Equal<uint>(32, tea.Calories);
        }

        /// <summary>
        /// Checks to make sure there are the correct number and name of ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal<int>(2, tea.Ingredients.Count);
        }

        /// <summary>
        /// Checks to make sure there are the correct number and name of ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredientsWithSweetner()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal<int>(2, tea.Ingredients.Count);
            if (tea.Sweet)
            {
                Assert.Contains<string>("Cane Sugar", tea.Ingredients);
                Assert.Equal<int>(3, tea.Ingredients.Count);
            }
        }

        /// <summary>
        /// Checks to make sure there are the correct number and name of ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectWithIngredientsLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal<int>(2, tea.Ingredients.Count);
            if (tea.Lemon)
            {
                Assert.Contains<string>("Lemon", tea.Ingredients);
                Assert.Equal<int>(3, tea.Ingredients.Count);
            }
        }

        /// <summary>
        /// Checks to make sure there are the correct number and name of ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredientsWithBothLemonAndSweetner()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal<int>(2, tea.Ingredients.Count);
            if (tea.Sweet && tea.Lemon)
            {
                Assert.Contains<string>("Cane Sugar", tea.Ingredients);
                Assert.Contains<string>("Lemon", tea.Ingredients);
                Assert.Equal<int>(4, tea.Ingredients.Count);
            }
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal($"{tea.Size} Tyrannotea", tea.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweetner();
            Assert.Equal($"{tea.Size} Sweet Tyrannotea", tea.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal($"Small Tyrannotea", tea.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal($"Medium Tyrannotea", tea.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal($"Large Tyrannotea", tea.Description);
        }

        [Fact]
        public void AddLemonShouldAddToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            if (tea.Lemon == true)
            {
                Assert.Collection<string>(tea.Special,
                    item =>
                    {
                        Assert.Equal("Add Lemon", item);
                    });
            }
        }

        [Fact]
        public void HoldingIceShouldAddToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            if (tea.Ice == true)
            {
                Assert.Collection<string>(tea.Special,
                    item =>
                    {
                        Assert.Equal("Hold Ice", item);
                    });
            }
        }

        [Fact]
        public void AddLemonAndHoldingIceShouldAddToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            tea.HoldIce();
                Assert.Collection<string>(tea.Special,
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
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.AddLemon();
            });
        }

        [Fact]
        public void AddingLemonShouldNotifyIngredientChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Ingredients", () =>
            {
                tea.AddLemon();
            });
        }

        [Fact]
        public void AddingSweetnerShouldNotifySpecialChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Ingredients", () =>
            {
                tea.AddSweetner();
            });
        }

        [Fact]
        public void AddingSweetnerShouldNotifyCalorieChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.AddSweetner();
            });
        }

        [Fact]
        public void RemoveSweetnerShouldNotifyIngredientChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Ingredients", () =>
            {
                tea.RemoveSweetner();
            });
        }

        [Fact]
        public void RemoveSweetnerShouldNotifyCalorieChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.RemoveSweetner();
            });
        }

        [Fact]
        public void ChangingSizeToSmallShouldNotifyCaloriesChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeToMediumShouldNotifyCaloriesChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeToLargeShouldNotifyCaloriesChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeToSmallShouldNotifyPriceChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeToMediumShouldNotifyPriceChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeToLargeShouldNotifyPriceChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Large;
            });
        }
    }
}
