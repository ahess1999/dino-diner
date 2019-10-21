/*  TRexKingBurger.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// TRexKingBurger class defines the menu item: Trex King Burger and it's ingredients along with the price and calories.
    /// </summary>
    public class TRexKingBurger : Entree, IOrderItem, INotifyPropertyChanged
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
        /// Property to add ingredients based on whether or not the customer wanted a certain ingredient on there order.
        /// </summary>
        /// <Returns>The ingredients that are included on the specific order.</Returns>
        public override List<string> Ingredients
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
        /// Returns the description or the name and all the contents of the item
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Adds to a list special cases for menu items
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Onions) special.Add("Hold Onion");
                if (!Bun) special.Add("Hold Whole Wheat Bun");
                if (!Ketchup) special.Add("Hold Ketchup");
                if (!Mustard) special.Add("Hold Mustard");
                if (!Pickle) special.Add("Hold Pickle");
                if (!Lettuce) special.Add("Hold Lettuce");
                if (!Tomato) special.Add("Hold Tomato");
                if (!Mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }

        /// <summary>
        /// An event handler for PropertyChanged events for special and ingredients
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Invokes a property change
        /// </summary>
        /// <param name="propertyName">The property to change</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the mustard
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the pickle
        /// </summary>
        public void HoldPickle()
        {
            this.Pickle = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the mayo
        /// </summary>
        public void HoldMayo()
        {
            this.Mayo = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the tomato
        /// </summary>
        public void HoldTomato()
        {
            this.Tomato = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the onion
        /// </summary>
        public void HoldOnion()
        {
            this.Onions = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Overrides the normal ToString method to return the correct name of the menu item
        /// </summary>
        /// <returns>The correct name of the menu item</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
