﻿/* OrderList.xaml.cs
 * Author: Austin Hess
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        /// <summary>
        /// Controls the navigation
        /// </summary>
        public NavigationService NavigationService { get; set; }
        /// <summary>
        /// Controls the Order list page
        /// </summary>
        public OrderList()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the remove button to remove from a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void RemoveItem(object sender, EventArgs args)
        {
            if(DataContext is Order order)
            {
                if(sender is FrameworkElement element)
                {
                    if(element.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }
        /// <summary>
        /// Takes the user to where they want to change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectionChanged(object sender, EventArgs args)
        {
            if(OrderItems.SelectedItem is Entree entree)
            {
                NavigationService?.Navigate(new EntreeSelection(entree));
            }
            if(OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }
            if(OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));
            }
        }
    }
}
