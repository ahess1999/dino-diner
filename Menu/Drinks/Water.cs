/*  Water.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that defines Water drink menu item
    /// </summary>
    public class Water : Drink
    {
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
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Large:
                        Price = 0.10;
                        Calories = 0;
                        break;
                }
            }
            get { return size; }
        }
        /// <summary>
        /// Method to add lemon
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }
        /// <summary>
        /// Constructor for Water that sets the default calories and price and defines the ingredients in the item
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
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
            if(size == Size.Small)
            {
                return "Small Water";
            }
            if (size == Size.Medium)
            {
                return "Medium Water";
            }
            if (size == Size.Large)
            {
                return "Large Water";
            }
            return "Water";
        }
    }
}
