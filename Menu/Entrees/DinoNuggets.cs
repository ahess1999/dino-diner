using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    class DinoNuggets
    {
        private bool Nugget = false;
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };
                if (Nugget) ingredients.Add("Chicken Nugget"); Nugget = false;
                return ingredients;
            }
        }
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }
        public void AddNugget()
        {
            Price += 0.25;
            Calories += 59;
            Nugget = true;
        }
    }
}
