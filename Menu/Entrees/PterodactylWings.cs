/*  PterdactylWings.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// PterodactylWings class defines the menu item: Pterodactyl Wings and it's ingredients along with the price and calories.
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// Property to get and set the price of the specific menu item
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Property to get and set the number of calories on the menu item
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Property to add ingredients based on whether or not the customer wanted a certain ingredient on there order.
        /// </summary>
        /// <Returns>The ingredients that are included on the specific order.</Returns>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }
        /// <summary>
        /// Constuctor that sets the price and calories of the Pterodactyl Wings
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
