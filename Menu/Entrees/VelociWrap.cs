/*  VelociWrap.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// VelociWrap class defines the menu item: Veloci Wrap and it's ingredients along with the price and calories.
    /// </summary>
    public class VelociWrap : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants cheese or not
        /// </summary>
        private bool Cheese = true;
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants lettuce or not
        /// </summary>
        private bool Lettuce = true;
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants dressing or not
        /// </summary>
        private bool Dressing = true;
        /// <summary>
        /// Property to add ingredients based on whether or not the customer wanted a certain ingredient on there order.
        /// </summary>
        /// <Returns>The ingredients that are included on the specific order.</Returns>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (Cheese) ingredients.Add("Parmesan Cheese");
                if (Lettuce) ingredients.Add("Romaine Lettuce");
                if (Dressing) ingredients.Add("Ceasar Dressing");
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
                if (!Cheese) special.Add("Hold Parmesan Cheese");
                if (!Lettuce) special.Add("Hold Romaine Lettuce");
                if (!Dressing) special.Add("Hold Ceasar Dressing");
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
        /// Constuctor that sets the price and calories of the Veloci Wrap.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the dressing
        /// </summary>
        public void HoldDressing()
        {
            this.Dressing = false;
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
        /// Method that tells whether or not the customer wants to hold the cheese
        /// </summary>
        public void HoldCheese()
        {
            this.Cheese = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Overrides the normal ToString method to return the correct name of the menu item
        /// </summary>
        /// <returns>The correct name of the menu item</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
