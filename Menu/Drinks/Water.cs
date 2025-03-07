﻿/*  Water.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that defines Water drink menu item
    /// </summary>
    public class Water : Drink, IOrderItem, INotifyPropertyChanged
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
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }
            get { return size; }
        }
        /// <summary>
        /// Method to add lemon
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
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
                if (Lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
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
        /// Constructor for Water that sets the default calories and price and defines the ingredients in the item
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
        }
        /// <summary>
        /// Property to add ingredients.
        /// </summary>
        /// <Returns>The ingredients that are included on the specific order.</Returns>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }
        /// <summary>
        /// Overrides the normal ToString method to return the correct name of the menu item
        /// </summary>
        /// <returns>The correct name of the menu item</returns>
        public override string ToString()
        {
            return $"{size} Water";
        }

        /// <summary>
        /// Method to hold the ice in the drink
        /// </summary>
        public override void HoldIce()
        {
            this.Ice = false;
            NotifyOfPropertyChanged("Special");
        }
    }
}
