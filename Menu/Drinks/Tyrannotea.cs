using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    class Tyrannotea : Drink
    {
        public bool Sweet { get; set; } = false;
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
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
            }
            get { return size; }
        }
        public void AddSweetner()
        {
            this.Sweet = true;
            Calories *= 2;
        }
        public void AddLemon()
        {
            this.Lemon = true;
        }
        public Tyrannotea()
        {
            Price = 1.50;
            Calories = 112;
            Ingredients.Add("Water");
            Ingredients.Add("Tea");
            if (Sweet) { Ingredients.Add("Cane Sugar"); }
            if (Lemon) { Ingredients.Add("Lemon"); }
        }
    }
}
