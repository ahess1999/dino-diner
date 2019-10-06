/*  PrehistoricPBJ.cs
*   Author: Austin Hess
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// PrehistroicPBJ class defines the menu item: Prehistoric PBJ and it's ingredients along with the price and calories.
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants peanut butter or not
        /// </summary>
        private bool PeanutButter = true;
        /// <summary>
        /// Boolean that tells the program whether or not the customer wants jelly or not
        /// </summary>
        private bool Jelly = true;
        /// <summary>
        /// Property to add ingredients based on whether or not the customer wanted a certain ingredient on there order.
        /// </summary>
        /// <Returns>The ingredients that are included on the specific order.</Returns>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (PeanutButter) ingredients.Add("Peanut Butter");
                if (Jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// Constuctor that sets the price and calories of the Prehistoric PBJ
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the peanut butter
        /// </summary>
        public void HoldPeanutButter()
        {
            this.PeanutButter = false;
        }
        /// <summary>
        /// Method that tells whether or not the customer wants to hold the jelly
        /// </summary>
        public void HoldJelly()
        {
            this.Jelly = false;
        }
        /// <summary>
        /// Overrides the normal ToString method to return the correct name of the menu item
        /// </summary>
        /// <returns>The correct name of the menu item</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
