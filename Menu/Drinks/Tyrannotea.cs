/*  Tyrannotea.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that defines Tyrannotea drink menu item
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Boolean that tells the program whether or not to add sweetner
        /// </summary>
        public bool Sweet { get; set; } = false;
        /// <summary>
        /// Boolean that tells the program whether or not to add lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

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
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
            }
            get { return size; }
        }
        /// <summary>
        /// Method to add sweetner
        /// </summary>
        public void AddSweetner()
        {
            this.Sweet = true;
            Calories *= 2;
        }
        /// <summary>
        /// Method to remove sweetner
        /// </summary>
        public void RemoveSweetner()
        {
            if (Sweet)
            {
                this.Sweet = false;
                Calories = Calories / 2;
            }
        }
        /// <summary>
        /// Method to add lemon
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }
        /// <summary>
        /// Constructor for Tyrannotea that sets the default calories and price and defines the ingredients in the item
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
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
                ingredients.Add("Tea");
                if (Sweet) ingredients.Add("Cane Sugar");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }
        /// <summary>
        /// Overrides the normal ToString method to return the correct name of the menu item
        /// </summary>
        /// <returns>The correct name of the menu item</returns>
        public override string ToString()
        {
            if (Sweet && size == Size.Small)
            {
                return "Small Sweet Tyrannotea";
            }
            if (Sweet && size == Size.Medium)
            {
                return "Medium Sweet Tyrannotea";
            }
            if (Sweet && size == Size.Large)
            {
                return "Large Sweet Tyrannotea";
            }
            if (size == Size.Small)
            {
                return "Small Tyrannotea";
            }
            if (size == Size.Medium)
            {
                return "Medium Tyrannotea";
            }
            if (size == Size.Large)
            {
                return "Large Tyrannotea";
            }
            return "Tyrannotea";
        }
    }
}
