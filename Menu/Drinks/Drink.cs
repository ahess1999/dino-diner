/*  Drink.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Base class for the drinks in the project
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Read-only list for the ingredients
        /// </summary>
        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients
        {
            get { return ingredients; }
        }
        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// Gets a sets the Ice property
        /// </summary>
        public virtual bool Ice { get; set; } = true;
        /// <summary>
        /// Returns the description or the name and all the contents of the item
        /// </summary>
        public virtual string Description { get; }
        /// <summary>
        /// Adds to a list special cases for menu items
        /// </summary>
        public virtual string[] Special { get; }
        /// <summary>
        /// An event handler for PropertyChanged events for special and ingredients
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Method to hold the ice in the drink
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }
    }
}
