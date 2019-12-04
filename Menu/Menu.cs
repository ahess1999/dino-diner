/* Menu.cs
 * Author: Austin Hess
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that adds and displays the entire menu
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Hashset of possible ingredients
        /// </summary>
        public HashSet<string> PossibleIngredients = new HashSet<string>();

        /// <summary>
        /// Adds all menu items to a list
        /// </summary>
        public List<IMenuItem> AvailableMenuItems { get; } = new List<IMenuItem>()
        {
                (new Brontowurst()),
                (new DinoNuggets()),
                (new PrehistoricPBJ()),
                (new PterodactylWings()),
                (new SteakosaurusBurger()),
                (new TRexKingBurger()),
                (new VelociWrap()),
                (new Fryceritops()),
                (new MeteorMacAndCheese()),
                (new MezzorellaSticks()),
                (new Triceritots()),
                (new JurassicJava()),
                (new Sodasaurus()),
                (new Tyrannotea()),
                (new Water()),
                (new CretaceousCombo(new Brontowurst())),
                (new CretaceousCombo(new DinoNuggets())),
                (new CretaceousCombo(new PrehistoricPBJ())),
                (new CretaceousCombo(new PterodactylWings())),
                (new CretaceousCombo(new SteakosaurusBurger())),
                (new CretaceousCombo(new TRexKingBurger())),
                new CretaceousCombo(new VelociWrap())
        };
        /// <summary>
        /// Adds all entrees to a list
        /// </summary>
        public List<IMenuItem> AvailableEntrees { get; } = new List<IMenuItem>()
        {
                (new Brontowurst()),
                (new DinoNuggets()),
                (new PrehistoricPBJ()),
                (new PterodactylWings()),
                (new SteakosaurusBurger()),
                (new TRexKingBurger()),
                (new VelociWrap())
        };
        /// <summary>
        /// Adds all sides to a list
        /// </summary>
        public List<IMenuItem> AvailableSides { get; } = new List<IMenuItem>()
        {
                (new Fryceritops()),
                (new MeteorMacAndCheese()),
                (new MezzorellaSticks()),
                (new Triceritots())
        };
        /// <summary>
        /// Adds all drinks to a list
        /// </summary>
        public List<IMenuItem> AvailableDrinks { get; } = new List<IMenuItem>()
        {
                (new JurassicJava()),
                (new Sodasaurus()),
                (new Tyrannotea()),
                (new Water())
        };
        /// <summary>
        /// Adds all combos to a list
        /// </summary>
        public List<IMenuItem> AvailableCombos { get; } = new List<IMenuItem>()
        {
                (new CretaceousCombo(new Brontowurst())),
                (new CretaceousCombo(new DinoNuggets())),
                (new CretaceousCombo(new PrehistoricPBJ())),
                (new CretaceousCombo(new PterodactylWings())),
                (new CretaceousCombo(new SteakosaurusBurger())),
                (new CretaceousCombo(new TRexKingBurger())),
                new CretaceousCombo(new VelociWrap())
        };
        /// <summary>
        /// Prints the entire menu
        /// </summary>
        /// <returns>The entire menu</returns>
        public override string ToString()
        {
            for(int i = 0; i < AvailableMenuItems.Count; i++)
            {
                return AvailableMenuItems[i].ToString() + " \n";
            }
            return "";
        }

        /// <summary>
        /// Returns search results based on the user's search
        /// </summary>
        /// <param name="menuitems">List of menu items</param>
        /// <param name="term">What is being searched for</param>
        /// <returns>List of items that are searched for</returns>
        public List<IMenuItem> Search(List<IMenuItem> menuitems, string term)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach(IMenuItem menu in menuitems)
            {
                if (menu.ToString().Contains(term))
                {
                    results.Add(menu);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters by what the item specifically is
        /// </summary>
        /// <param name="menuitems">List of menu items</param>
        /// <param name="filters">filters that the user has selected</param>
        /// <returns>A list of combos, or entrees, or sides, or drinks</returns>
        public List<IMenuItem> Filter(List<IMenuItem> menuitems, List<string> filters)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in menuitems)
            {
                if (item is CretaceousCombo && filters.Contains("Combo"))
                {
                    results.Add(item);
                }
                if (item is Entree && filters.Contains("Entree"))
                {
                    results.Add(item);
                }
                if (item is Side && filters.Contains("Side"))
                {
                    results.Add(item);
                }
                if (item is Drink && filters.Contains("Drink"))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters based on ingredients
        /// </summary>
        /// <param name="menuitems">List of menu items to iterate through</param>
        /// <param name="ingredients">List of all ingredients</param>
        /// <returns>The list filtered by ingredients</returns>
        public List<IMenuItem> FilterIngredients(List<IMenuItem> menuitems, List<string> ingredients)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem menu in menuitems)
            {
                bool Keep = true;
                foreach(string s in ingredients)
                {
                    if (menu.Ingredients.Contains(s))
                    {
                        Keep = false;
                        menuitems.Remove(menu);
                    }
                }
                if (Keep)
                {
                    results.Add(menu);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters by a minimum price
        /// </summary>
        /// <param name="menuitems">List of items to iterate through</param>
        /// <param name="minimumPrice">The min price decided by the user</param>
        /// <returns>The list of items based upon the minimum price</returns>
        public List<IMenuItem> FilterByMinPrice(List<IMenuItem> menuitems, double? minimumPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach(IMenuItem menu in menuitems)
            {
                if(minimumPrice <= menu.Price)
                {
                    results.Add(menu);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters by a maximum price
        /// </summary>
        /// <param name="menuitems">List of items to iterate through</param>
        /// <param name="maximumPrice">The max price decided by the user</param>
        /// <returns>The list of items based upon the maximum price</returns>
        public List<IMenuItem> FilterByMaxPrice(List<IMenuItem> menuitems, double? maximumPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem menu in menuitems)
            {
                if (maximumPrice >= menu.Price)
                {
                    results.Add(menu);
                }
            }
            return results;
        }

        /// <summary>
        /// Adds to the PossibleIngredients Hashset for all ingredients
        /// </summary>
        /// <param name="menuitems">List of items to iterate through</param>
        public void AllIngredients(List<IMenuItem> menuitems)
        {
            foreach(IMenuItem menu in menuitems)
            {
                foreach(string s in menu.Ingredients)
                {
                    PossibleIngredients.Add(s);
                }
            }
        }
    }
}
