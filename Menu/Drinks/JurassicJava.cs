/*  JurassicJava.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurassicJava : Drink
    {
        public bool RoomForCream { get; set; } = false;
        public bool Decaf { get; set; } = false;
        private Size size;

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
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }
        public void AddIce()
        {
            this.Ice = true;
        }
        public JurassicJava()
        {
            Ice = false;
            Price = 0.59;
            Calories = 2;
            Ingredients.Add("Water");
            Ingredients.Add("Coffee");
        }
    }
}
