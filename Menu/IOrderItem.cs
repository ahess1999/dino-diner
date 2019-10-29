/* IOrderItem.cs
 * Author: Austin Hess
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for ordering items off the menu
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Price of item
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Description of the item
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Contains instructions for the item, Ex. HoldKetchup method
        /// </summary>
        string[] Special { get; }
    }
}
