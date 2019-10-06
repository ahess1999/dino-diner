/*  Sodasaurus.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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
        }
        /// <summary>
        /// Property to add ingredients.
        /// </summary>
        /// <Returns>The ingredients that are included on the specific order.</Returns>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }
        /// <summary>
        /// Overrides the normal ToString method to return the correct name of the menu item
        /// </summary>
        /// <returns>The correct name of the menu item</returns>
        public override string ToString()
        {
            if(size == Size.Small && flavor == SodasaurusFlavor.Cherry)
            {
                return "Small Cherry Sodasaurus";
            }
            if (size == Size.Medium && flavor == SodasaurusFlavor.Cherry)
            {
                return "Medium Cherry Sodasaurus";
            }
            if (size == Size.Large && flavor == SodasaurusFlavor.Cherry)
            {
                return "Large Cherry Sodasaurus";
            }
            if (size == Size.Small && flavor == SodasaurusFlavor.Chocolate)
            {
                return "Small Chocolate Sodasaurus";
            }
            if (size == Size.Medium && flavor == SodasaurusFlavor.Chocolate)
            {
                return "Medium Chocolate Sodasaurus";
            }
            if (size == Size.Large && flavor == SodasaurusFlavor.Chocolate)
            {
                return "Large Chocolate Sodasaurus";
            }
            if (size == Size.Small && flavor == SodasaurusFlavor.Cola)
            {
                return "Small Cola Sodasaurus";
            }
            if (size == Size.Medium && flavor == SodasaurusFlavor.Cola)
            {
                return "Medium Cola Sodasaurus";
            }
            if (size == Size.Large && flavor == SodasaurusFlavor.Cola)
            {
                return "Large Cola Sodasaurus";
            }
            if (size == Size.Small && flavor == SodasaurusFlavor.Lime)
            {
                return "Small Lime Sodasaurus";
            }
            if (size == Size.Medium && flavor == SodasaurusFlavor.Lime)
            {
                return "Medium Lime Sodasaurus";
            }
            if (size == Size.Large && flavor == SodasaurusFlavor.Lime)
            {
                return "Large Lime Sodasaurus";
            }
            if (size == Size.Small && flavor == SodasaurusFlavor.Orange)
            {
                return "Small Orange Sodasaurus";
            }
            if (size == Size.Medium && flavor == SodasaurusFlavor.Orange)
            {
                return "Medium Orange Sodasaurus";
            }
            if (size == Size.Large && flavor == SodasaurusFlavor.Orange)
            {
                return "Large Orange Sodasaurus";
            }
            if (size == Size.Small && flavor == SodasaurusFlavor.RootBeer)
            {
                return "Small RootBeer Sodasaurus";
            }
            if (size == Size.Medium && flavor == SodasaurusFlavor.RootBeer)
            {
                return "Medium RootBeer Sodasaurus";
            }
            if (size == Size.Large && flavor == SodasaurusFlavor.RootBeer)
            {
                return "Large RootBeer Sodasaurus";
            }
            if (size == Size.Small && flavor == SodasaurusFlavor.Vanilla)
            {
                return "Small Vanilla Sodasaurus";
            }
            if (size == Size.Medium && flavor == SodasaurusFlavor.Vanilla)
            {
                return "Medium Vanilla Sodasaurus";
            }
            if (size == Size.Large && flavor == SodasaurusFlavor.Vanilla)
            {
                return "Large Vanilla Sodasaurus";
            }
            return "Sodasaurus";
        }
    }
}
