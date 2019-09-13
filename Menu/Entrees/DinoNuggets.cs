/*  DinoNuggets.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// DinoNuggets class defines the menu item: Dino Nuggets and it's ingredients along with the price and calories.
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants to add more nuggets
        /// </summary>
        private bool Nugget = false;
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
                List<string> ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };
                if (Nugget) ingredients.Add("Chicken Nugget"); Nugget = false;
                return ingredients;
            }
        }
        /// <summary>
        /// Constuctor that sets the price and calories of the Dino Nuggets.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to add more nuggets to their meal and updates the price and calories
        /// </summary>
        public void AddNugget()
        {
            Price += 0.25;
            Calories += 59;
            Nugget = true;
        }
    }
}
