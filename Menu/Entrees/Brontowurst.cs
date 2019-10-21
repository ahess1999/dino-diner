
/*  Brontowurst.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Brontowurst class defines the menu item: Brontowurst and it's ingredients along with the price and calories.
    /// </summary>
    public class Brontowurst : Entree, IOrderItem, INotifyPropertyChanged
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
                if (!Bun) special.Add("Hold Whole Wheat Bun");
                if (!Peppers) special.Add("Hold Peppers");
                if (!Onions) special.Add("Hold Onion");
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
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.Peppers = false;
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
            return "Brontowurst";
        }
    }
}
