/*  Water.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
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
            ingredients.Add("Water");
            if(Lemon) { ingredients.Add("Lemon"); }
        }
    }
}
