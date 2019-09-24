using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public enum Size
    {
        Small,
        Medium,
        Large
    }
    public abstract class Drink
    {
        protected List<string> ingredients = new List<string>();
        public double Price { get; set; }
        public uint Calories { get; set; }
        public virtual List<string> Ingredients
        {
            get { return ingredients; }
        }
        public virtual Size Size { get; set; }

        public bool Ice { get; set; } = true;
        public void HoldIce()
        {
            this.Ice = false;
        }
    }
}
