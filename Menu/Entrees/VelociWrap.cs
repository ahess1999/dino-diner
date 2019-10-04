/*  VelociWrap.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// VelociWrap class defines the menu item: Veloci Wrap and it's ingredients along with the price and calories.
    /// </summary>
    public class VelociWrap : Entree
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
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the cheese
        /// </summary>
        public void HoldCheese()
        {
            this.Cheese = false;
        }
    }
}
