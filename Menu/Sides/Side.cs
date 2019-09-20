﻿/*  Side.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Enum that defines the sizes of the sides avaliable on the menu
    /// </summary>
    public enum Size
    {
        Small,
        Medium, 
        Large
    }
    /// <summary>
    /// Base class for the side menu options
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// Read-only list of ingredients for the sides
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
        public List<string> Ingredients { get { return ingredients; } }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

    }
}
