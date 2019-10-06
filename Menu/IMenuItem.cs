/* IMenuItem.cs
 * Author: Austin Hess
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for the Dino diner
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Gets the price
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Gets the calories
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// Gets the ingredients
        /// </summary>
        List<string> Ingredients { get; }
    }
}
