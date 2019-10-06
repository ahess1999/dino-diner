/*  SteakosaurusBurger.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// SteakosaurusBurger class defines the menu item: Steakosaurus Burger and it's ingredients along with the price and calories.
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants Bun or not
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants Ketchup or not
        /// </summary>
        private bool Ketchup = true;
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants Mustard or not
        /// </summary>
        private bool Mustard = true;
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants Pickle or not
        /// </summary>
        private bool Pickle = true;
        /// <summary>
        /// Property to add ingredients based on whether or not the customer wanted a certain ingredient on there order.
        /// </summary>
        /// <Returns>The ingredients that are included on the specific order.</Returns>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (Ketchup) ingredients.Add("Ketchup");
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Mustard) ingredients.Add("Mustard");
                if (Pickle) ingredients.Add("Pickle");
                return ingredients;
            }
        }
        /// <summary>
        /// Constuctor that sets the price and calories of the Steaksaurus Burger
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the bun
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false;
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the mustard
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the pickle
        /// </summary>
        public void HoldPickle()
        {
            this.Pickle = false;
        }
        /// <summary>
        /// Overrides the normal ToString method to return the correct name of the menu item
        /// </summary>
        /// <returns>The correct name of the menu item</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
