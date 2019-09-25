/*  Water.cs
*   Author: Austin Hess
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    class Water : Drink
    {
        public bool Lemon { get; set; } = false;
        private Size size;

        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Large:
                        Price = 0.10;
                        Calories = 0;
                        break;
                }
            }
            get { return size; }
        }
        public void AddLemon()
        {
            this.Lemon = true;
        }
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            ingredients.Add("Water");
            if(Lemon) { ingredients.Add("Lemon"); }
        }
    }
}
