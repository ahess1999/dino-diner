using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        private bool Cheese = true;
        private bool Lettuce = true;
        private bool Dressing = true;
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (Cheese) ingredients.Add("Parmesan Cheese");
                if (Lettuce) ingredients.Add("Romaine Lettuce");
                if (Dressing) ingredients.Add("Ceasar Dressing");
                return ingredients;
            }
        }
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldDressing()
        {
            this.Dressing = false;
        }

        public void HoldLettuce()
        {
            this.Lettuce = false;
        }

        public void HoldCheese()
        {
            this.Cheese = false;
        }
    }
}
