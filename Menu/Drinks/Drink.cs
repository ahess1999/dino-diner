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
        /// Local size variable
        /// </summary>
        private Size size;
        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Size");
            }
        }
        /// <summary>
        /// Gets and sets the Ice property
        /// </summary>
        public virtual bool Ice { get; set; } = true;
        /// <summary>
        /// Gets and sets the Sweet property
        /// </summary>
        public virtual bool Sweet { get; set; } = false;
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
        public virtual void HoldIce()
        {
            this.Ice = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Invokes a property change
        /// </summary>
        /// <param name="propertyName">The property to change</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Method to add sweetner
        /// </summary>
        public virtual void AddSweetner()
        {
            this.Sweet = true;
            Calories *= 2;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Description");
        }
        /// <summary>
        /// Method to remove sweetner
        /// </summary>
        public virtual void RemoveSweetner()
        {
            if (Sweet)
            {
                this.Sweet = false;
                Calories = Calories / 2;
            }
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Calories");
        }
    }
}
