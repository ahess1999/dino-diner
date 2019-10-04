/*  Brontowurst.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Brontowurst class defines the menu item: Brontowurst and it's ingredients along with the price and calories.
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        /// Boolean that tells the progrmam to include the bun or not
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// Boolean that tells the program to include peppers or not
        /// </summary>
        private bool Peppers = true;
        /// <summary>
        /// Boolean that tells the program to include onions or not
        /// </summary>
        private bool Onions = true;
        /// <summary>
        /// Property to add ingredients based on whether or not the customer wanted a certain ingredient on there order.
        /// </summary>
        /// <Returns>The ingredients that are included on the specific order.</Returns>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (Onions) ingredients.Add("Onion");
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                return ingredients;
            }
        }
        /// <summary>
        /// Constuctor that sets the price and calories of the Brontowurst
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the bun
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false;
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.Peppers = false;
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the onion
        /// </summary>
        public void HoldOnion()
        {
            this.Onions = false;
        }
    }
}
