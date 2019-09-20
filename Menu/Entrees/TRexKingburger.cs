/*  TRexKingBurger.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// TRexKingBurger class defines the menu item: Trex King Burger and it's ingredients along with the price and calories.
    /// </summary>
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants Bun or not
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants lettuce or not
        /// </summary>
        private bool Lettuce = true;
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants tomato or not
        /// </summary>
        private bool Tomato = true;
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants pickle or not
        /// </summary>
        private bool Pickle = true;
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants ketchup or not
        /// </summary>
        private bool Ketchup = true;
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants mustard or not
        /// </summary>
        private bool Mustard = true;
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants mayo or not
        /// </summary>
        private bool Mayo = true;
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants onion or not
        /// </summary>
        private bool Onions = true;
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
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (Onions) ingredients.Add("Onion");
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                if (Pickle) ingredients.Add("Pickle");
                if (Lettuce) ingredients.Add("Lettuce");
                if (Tomato) ingredients.Add("Tomato");
                if (Mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }
        /// <summary>
        /// Constuctor that sets the price and calories of the TRex King Burger
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
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
        /// Method that tells whether or not the customer wants to hold the mayo
        /// </summary>
        public void HoldMayo()
        {
            this.Mayo = false;
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the tomato
        /// </summary>
        public void HoldTomato()
        {
            this.Tomato = false;
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
