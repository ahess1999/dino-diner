﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public enum SodasaurusFlavor
    {
        Cola,
        Orange,
        Vanilla,
        Chocolate,
        RootBeer,
        Cherry,
        Lime
    }
    public class Sodasaurus : Drink
    {
        public SodasaurusFlavor Flavor { get; set; }

        private Size size;
        
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
            get { return size; }
        }

        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            Ingredients.Add("Water");
            Ingredients.Add("Natural Flavors");
            Ingredients.Add("Cane Sugar");
        }
    }
}
