/*  DinoNuggets.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// DinoNuggets class defines the menu item: Dino Nuggets and it's ingredients along with the price and calories.
    /// </summary>
    public class DinoNuggets : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants to add more nuggets
        /// </summary>
        private int NuggetCount = 6;
        /// <summary>
        /// Property to add ingredients based on whether or not the customer wanted a certain ingredient on there order.
        /// </summary>
        /// <Returns>The ingredients that are included on the specific order.</Returns>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {  };
                for(int i = 0; i < NuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
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
                if(NuggetCount > 6)
                {
                    special.Add(NuggetCount + " Extra Nuggets");
                }
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
            NuggetCount++;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Price");
        }

        /// <summary>
        /// Overrides the normal ToString method to return the correct name of the menu item
        /// </summary>
        /// <returns>The correct name of the menu item</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
