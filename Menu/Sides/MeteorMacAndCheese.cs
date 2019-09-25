﻿/*  MeteorMacAndCheese.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Meteor Mac and Cheese side menu option
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// Controls the size of the side that is being ordered
        /// </summary>
        private Size size;
        /// <summary>
        /// Defines and updates the size along with the calories and price that goes along with that specific size
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
            get { return size; }
        }
        /// <summary>
        /// Constructor that sets the default ingredients and the size and price to the smallest size
        /// </summary>
        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;
            Ingredients.Add("Macaroni Noodles");
            Ingredients.Add("Cheese Product");
            Ingredients.Add("Pork Sausage");
        }
    }
}