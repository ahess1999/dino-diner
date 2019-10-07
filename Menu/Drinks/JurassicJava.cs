/*  JurassicJava.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that defines JurassicJava drink menu item
    /// </summary>
    public class JurassicJava : Drink
    {
        /// <summary>
        /// Boolean that tells the program whether or not to add cream
        /// </summary>
        public bool SpaceForCream { get; set; } = false;
        /// <summary>
        /// Boolean that tells the program whether ornot the coffee should be decaf
        /// </summary>
        public bool Decaf { get; set; } = false;
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
                        Price = 0.59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }
            get { return size; }
        }
        /// <summary>
        /// Method to add cream
        /// </summary>
        public void LeaveSpaceForCream()
        {
            this.SpaceForCream = true;
        }
        /// <summary>
        /// Method to make coffee decaf
        /// </summary>
        public void DecafJava()
        {
            this.Decaf = true;
        }
        /// <summary>
        /// Method to add ice
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
        }
        /// <summary>
        /// Constructor for JurassicJava that sets the default calories and price and defines the ingredients in the item
        /// </summary>
        public JurassicJava()
        {
            Ice = false;
            Price = 0.59;
            Calories = 2;
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
                ingredients.Add("Coffee");
                return ingredients;
            }
        }
        /// <summary>
        /// Overrides the normal ToString method to return the correct name of the menu item
        /// </summary>
        /// <returns>The correct name of the menu item</returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return $"{size} Decaf Jurassic Java";
            }
            else
            {
                return $"{size} Jurassic Java";
            }
        }
    }
}
