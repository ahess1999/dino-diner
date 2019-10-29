/* Order.cs
 * Author: Austin Hess
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents a new customer order and calculates the cost of everything with tax
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Variable to store tax rate
        /// </summary>
        private double salesTaxRate;
        /// <summary>
        /// All items in the order
        /// </summary>
        public List<IOrderItem> items;
        /// <summary>
        /// Collection of items in the order
        /// </summary>
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }
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
        public double SalesTaxRate
        {
            get { return salesTaxRate; }
            set
            {
                if(value < 0)
                {
                    return;
                }
                salesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }
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
        /// <summary>
        /// Event handler for the property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Creates new order instance
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
        }
        /// <summary>
        /// Adds the item to the list
        /// </summary>
        /// <param name="item">Item being added</param>
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }
        /// <summary>
        /// Removes the item from the list
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }
        /// <summary>
        /// Updates the cost when the collection is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
