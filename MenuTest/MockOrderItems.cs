/* MockOrderItems.cs
 * Author: Austin Hess
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using System.ComponentModel;

namespace MenuTest
{
    /// <summary>
    /// Creates mock items to test the funtionality of the order class
    /// </summary>
    /*public class MockOrderItems : IOrderItem
    {
        /// <summary>
        /// Returns the description or the name and all the contents of the item
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Price of the items
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Adds to a list special cases for menu items
        /// </summary>
        public string[] Special { get; set; }


        public class MockOrderItem1 : IOrderItem
        {
            /// <summary>
            /// Returns the description or the name and all the contents of the item
            /// </summary>
            public string Description { get; set; }
            /// <summary>
            /// Price of the items
            /// </summary>
            public double Price { get; set; } = 3.50;
            /// <summary>
            /// Adds to a list special cases for menu items
            /// </summary>
            public string[] Special { get; set; }
            /// <summary>
            /// Empty constructor so there is no need for a passed parameter
            /// </summary>
            public MockOrderItem1()
            {

            }
            /// <summary>
            /// Constructor that sets the price of the mock item
            /// </summary>
            /// <param name="price"></param>
            public MockOrderItem1(double price)
            {
                this.Price = price;
            }

        }

        public class MockOrderItem2 : IOrderItem
        {
            /// <summary>
            /// Returns the description or the name and all the contents of the item
            /// </summary>
            public string Description { get; set; }
            /// <summary>
            /// Price of the items
            /// </summary>
            public double Price { get; set; } = 3.50;
            /// <summary>
            /// Adds to a list special cases for menu items
            /// </summary>
            public string[] Special { get; set; }
            /// <summary>
            /// Empty constructor so there is no need for a passed parameter
            /// </summary>
            public MockOrderItem2()
            {

            }
            /// <summary>
            /// Constructor that sets the price of the mock item
            /// </summary>
            /// <param name="price"></param>
            public MockOrderItem2(double price)
            {
                this.Price = price;
            }
        }

        public class MockOrderItem3 : IOrderItem
        {
            /// <summary>
            /// Returns the description or the name and all the contents of the item
            /// </summary>
            public string Description { get; set; }
            /// <summary>
            /// Price of the items, high negative value to check that it can't be negative
            /// </summary>
            public double Price { get; set; } = -7.50;
            /// <summary>
            /// Adds to a list special cases for menu items
            /// </summary>
            public string[] Special { get; set; }
            /// <summary>
            /// Empty constructor so there is no need for a passed parameter
            /// </summary>
            public MockOrderItem3()
            {

            }
            /// <summary>
            /// Constructor that sets the price of the mock item
            /// </summary>
            /// <param name="price"></param>
            public MockOrderItem3(double price)
            {
                this.Price = price;
            }

        }
    }*/
}
