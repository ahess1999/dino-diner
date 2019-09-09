using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        private bool Bun = true;
        private bool Peppers = true;
        private bool Onions = true;
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (Onions) ingredients.Add("Onions");
                if (Bun) ingredients.Add("Bun");
                if (Peppers) ingredients.Add("Peppers");
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldBun()
        {
            this.Bun = false;
        }

        public void HoldPeppers()
        {
            this.Peppers = false;
        }

        public void HoldOnions()
        {
            this.Onions = false;
        }
    }
}
