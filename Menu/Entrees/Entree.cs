/*  Entree.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Base class for entree menu options
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Read-only list of ingredients for the entrees
        /// </summary>
        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }
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
    }
}
