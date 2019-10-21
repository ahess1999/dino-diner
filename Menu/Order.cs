/* Order.cs
 * Author: Austin Hess
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents a new customer order and calculates the cost of everything with tax
    /// </summary>
    public class Order
    {
        /// <summary>
        /// All items in the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();
        /// <summary>
        /// Total price of all items
        /// </summary>
        public double SubTotalCost
        {
            get
            {
                double sum = 0;
                foreach(IOrderItem i in Items)
                {
                    sum = sum + i.Price;
                }
                if(sum < 0)
                {
                    sum = 0;
                }
                return sum;
            }
        }
        /// <summary>
        /// Sales tax rate for items
        /// </summary>
        public double SalesTaxRate { get; protected set; }
        /// <summary>
        /// Sales tax cost based on the subtotal and the tax rate
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return (SalesTaxRate * SubTotalCost);
            }
        }
        /// <summary>
        /// Total cost of everything with the sales tax
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubTotalCost + SalesTaxCost;
            }
        }
    }
}
