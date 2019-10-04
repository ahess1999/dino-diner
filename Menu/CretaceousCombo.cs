/* CretaceousCombo.cs
 * Author: Austin Hess
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that defines comboes for the menu in dino diner
    /// </summary>
    public class CretaceousCombo : IMenuItem
    {
        /// <summary>
        /// Property that gets and sets the entree that the user selects
        /// </summary>
        public Entree Entree { get; set; }
        /// <summary>
        /// Private variable that gets and returns the side selected and the specific size for that side
        /// </summary>
        private Side side { get { return side; } set { this.side = value; this.side.Size = this.size; } }
        /// <summary>
        /// Property that gets and sets the side that the user selects
        /// </summary>
        public Side Side { get; set; }
        /// <summary>
        /// Private variable that gets and returns the drink selected and the specific size for that side
        /// </summary>
        private Drink drink { get { return drink; } set { this.drink = value; this.drink.Size = this.Size; } }
        /// <summary>
        /// Property that gets and sets the drink that the user selects
        /// </summary>
        public Drink Drink { get; set; }
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
        /// Constructor for the CretaceousCombo class that sets the Entree to what the user selects, sets side to Fryceritops by default, and drink to sodasaurus by default
        /// </summary>
        /// <param name="entree">Entree the user selects to add to the combo</param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();

        }
    }
}
