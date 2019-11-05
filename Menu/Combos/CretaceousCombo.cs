/* CretaceousCombo.cs
 * Author: Austin Hess
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that defines comboes for the menu in dino diner
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// An event handler for PropertyChanged events for special and ingredients
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Invokes a property change
        /// </summary>
        /// <param name="propertyName">The property to change</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Privated variable for an Entree
        /// </summary>
        private Entree entree;
        /// <summary>
        /// Property that gets and sets the entree that the user selects
        /// </summary>
        public Entree Entree
        {
            get { return entree; }
            protected set
            {
                entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                };
            }
        }
        /// <summary>
        /// Private variable that gets and returns the side selected and the specific size for that side
        /// </summary>
        private Side side;
        /// <summary>
        /// Property that gets and sets the side that the user selects
        /// </summary>
        public Side Side
        {
            get { return side; }
            set
            {
                this.side = value;
                this.side.Size = this.size;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }
        }
        /// <summary>
        /// Private variable that gets and returns the drink selected and the specific size for that side
        /// </summary>
        private Drink drink;
        /// <summary>
        /// Property that gets and sets the drink that the user selects
        /// </summary>
        public Drink Drink
        {
            get { return drink; }
            set
            {
                this.drink = value;
                this.drink.Size = this.size;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }
        }
        /// <summary>
        /// Property that gets the price of the entree, side, and drink and lowers the price by 25 cents for the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }
        /// <summary>
        /// Property that gets the price of the entree, side, and drink and adds them up to display the total calories
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }
        /// <summary>
        /// Private variable that sets the size of the combo to small by default
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// Property that gets the size and sets the size of the side and drink based on the size receieved
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
        }
        /// <summary>
        /// Property that creates a list of ingredients and adds all of the ingredients of the entree, side, and drink and returns that list
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }
        /// <summary>
        /// Returns the description or the name and all the contents of the item
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Adds to a list special cases for menu items
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for the CretaceousCombo class that sets the Entree to what the user selects, sets side to Fryceritops by default, and drink to sodasaurus by default
        /// </summary>
        /// <param name="entree">Entree the user selects to add to the combo</param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();

        }
        /// <summary>
        /// Changes the name of the combo based upon the type of combo ordered
        /// </summary>
        /// <returns>The correct name of the combo ordered</returns>
        public override string ToString()
        {
            return $"{Entree} Combo";
        }
    }
}
