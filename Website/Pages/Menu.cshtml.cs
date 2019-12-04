/* Menu.cshtml.cs
 * Author: Austin Hess
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// Menu items
        /// </summary>
        public Menu Menu { get; } = new Menu();
        /// <summary>
        /// Represents the search
        /// </summary>
        [BindProperty]
        public string Search { get; set; }
        /// <summary>
        /// List of menu items
        /// </summary>
        [BindProperty]
        public List<IMenuItem> MenuItems { get; set; }
        /// <summary>
        /// List of combos
        /// </summary>
        [BindProperty]
        public List<IMenuItem> Combos { get; set; }
        /// <summary>
        /// List of entrees
        /// </summary>
        [BindProperty]
        public List<IMenuItem> Entrees { get; set; }
        /// <summary>
        /// List of sides
        /// </summary>
        [BindProperty]
        public List<IMenuItem> Sides { get; set; }
        /// <summary>
        /// List of drinks
        /// </summary>
        [BindProperty]
        public List<IMenuItem> Drinks { get; set; }
        /// <summary>
        /// Minimum price to filter by
        /// </summary>
        [BindProperty]
        public double? MinimumPrice { get; set; }
        /// <summary>
        /// Maximum price to filter by
        /// </summary>
        [BindProperty]
        public double? MaximumPrice { get; set; }
        /// <summary>
        /// List of things to filter by
        /// </summary>
        [BindProperty]
        public List<string> Filter { get; set; } = new List<string>();
        /// <summary>
        /// List of ingredients
        /// </summary>
        [BindProperty]
        public List<string> Ingredients { get; set; } = new List<string>();
        /// <summary>
        /// HashSet for the possible ingredients
        /// </summary>
        [BindProperty]
        public HashSet<string> PossibleIngredientsHashSet { get; set; } = new HashSet<string>();
        /// <summary>
        /// Constructor for Menu razor page
        /// </summary>
        public void OnGet()
        {
            Combos = Menu.AvailableCombos;
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            Drinks = Menu.AvailableDrinks;
            MenuItems = Menu.AvailableMenuItems;
            Menu.AllIngredients(Combos);
            Menu.AllIngredients(Entrees);
            Menu.AllIngredients(Sides);
            Menu.AllIngredients(Drinks);
            PossibleIngredientsHashSet = Menu.PossibleIngredients;
        }
        /// <summary>
        /// Whenever something is clicked this happens
        /// </summary>
        public void OnPost()
        {
            Combos = Menu.AvailableCombos;
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            MenuItems = Menu.AvailableMenuItems;
            Drinks = Menu.AvailableDrinks;
            Menu.AllIngredients(Combos);
            Menu.AllIngredients(Entrees);
            Menu.AllIngredients(Sides);
            Menu.AllIngredients(Drinks);
            PossibleIngredientsHashSet = Menu.PossibleIngredients;
            if(Search != null)
            {
                Combos = Menu.Search(Combos, Search);
                Entrees = Menu.Search(Entrees, Search);
                Sides = Menu.Search(Sides, Search);
                Drinks = Menu.Search(Drinks, Search);
            }
            if(Filter.Count != 0)
            {
                Combos = Menu.Filter(Combos, Filter);
                Entrees = Menu.Filter(Entrees, Filter);
                Sides = Menu.Filter(Sides, Filter);
                Drinks = Menu.Filter(Drinks, Filter);
            }
            if(Ingredients.Count != 0)
            {
                Combos = Menu.FilterIngredients(Combos, Ingredients);
                Entrees = Menu.FilterIngredients(Entrees, Ingredients);
                Sides = Menu.FilterIngredients(Sides, Ingredients);
                Drinks = Menu.FilterIngredients(Drinks, Ingredients);
            }
            if(MinimumPrice != null)
            {
                Combos = Menu.FilterByMinPrice(Combos, MinimumPrice);
                Entrees = Menu.FilterByMinPrice(Entrees, MinimumPrice);
                Sides = Menu.FilterByMinPrice(Sides, MinimumPrice);
                Drinks = Menu.FilterByMinPrice(Drinks, MinimumPrice);
            }
            if(MaximumPrice != null)
            {
                Combos = Menu.FilterByMaxPrice(Combos, MaximumPrice);
                Entrees = Menu.FilterByMaxPrice(Entrees, MaximumPrice);
                Sides = Menu.FilterByMaxPrice(Sides, MaximumPrice);
                Drinks = Menu.FilterByMaxPrice(Drinks, MaximumPrice);
            }
        }
    }
}