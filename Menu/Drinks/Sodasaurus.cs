/*  Sodasaurus.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class that defines Sodasaurus drink menu item
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Private variable used to call from the enum
        /// </summary>
        private SodasaurusFlavor flavor;
        /// <summary>
        /// Property that accesses the enum to set the flavor of the sodasaurus
        /// </summary>
        public SodasaurusFlavor Flavor { get { return flavor; } set { flavor = value; } }
        /// <summary>
        /// Private variable that updates the size of the drinks
        /// </summary>
        private Size size;
        /// <summary>
        /// Property that tells the program what the price and calories are based on the size of the drink
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
            get { return size; }
        }
        /// <summary>
        /// Constructor for Sodasaurus that sets the default calories and price and defines the ingredients in the item
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            Ingredients.Add("Water");
            Ingredients.Add("Natural Flavors");
            Ingredients.Add("Cane Sugar");
        }
    }
}
