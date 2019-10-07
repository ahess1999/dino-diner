/*  Triceritots.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Triceritots side menu option
    /// </summary>
    public class Triceritots : Side
    {
        /// <summary>
        /// Controls the size of the side that is being ordered
        /// </summary>
        private Size size;
        /// <summary>
        /// Defines and updates the size along with the calories and price that goes along with that specific size
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
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
            get { return size; }
        }
        /// <summary>
        /// Constructor that sets the default ingredients and the size and price to the smallest size
        /// </summary>
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
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
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }
        /// <summary>
        /// Overrides the normal ToString method to return the correct name of the menu item
        /// </summary>
        /// <returns>The correct name of the menu item</returns>
        public override string ToString()
        { 
            return $"{size} Triceritots";
        }
    }
}
