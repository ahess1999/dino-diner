using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
    {
        private bool Bun = true;
        private bool Lettuce = true;
        private bool Tomato = true;
        private bool Pickle = true;
        private bool Ketchup = true;
        private bool Mustard = true;
        private bool Mayo = true;
        private bool Onions = true;
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (Onions) ingredients.Add("Onion");
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                if (Pickle) ingredients.Add("Pickle");
                if (Lettuce) ingredients.Add("Lettuce");
                if (Tomato) ingredients.Add("Tomato");
                if (Mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        public void HoldBun()
        {
            this.Bun = false;
        }
        public void HoldKetchup()
        {
            this.Ketchup = false;
        }

        public void HoldMustard()
        {
            this.Mustard = false;
        }

        public void HoldPickle()
        {
            this.Pickle = false;
        }

        public void HoldMayo()
        {
            this.Mayo = false;
        }

        public void HoldLettuce()
        {
            this.Lettuce = false;
        }

        public void HoldTomato()
        {
            this.Tomato = false;
        }

        public void HoldOnion()
        {
            this.Onions = false;
        }
    }
}
