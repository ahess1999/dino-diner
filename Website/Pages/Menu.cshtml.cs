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
        public IEnumerable<IMenuItem> MenuItems { get; set; }
        /// <summary>
        /// List of combos
        /// </summary>
        [BindProperty]
        public IEnumerable<IMenuItem> Combos { get; set; }
        /// <summary>
        /// List of entrees
        /// </summary>
        [BindProperty]
        public IEnumerable<IMenuItem> Entrees { get; set; }
        /// <summary>
        /// List of sides
        /// </summary>
        [BindProperty]
        public IEnumerable<IMenuItem> Sides { get; set; }
        /// <summary>
        /// List of drinks
        /// </summary>
        [BindProperty]
        public IEnumerable<IMenuItem> Drinks { get; set; }
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
            Menu.AllIngredients(Menu.AvailableCombos);
            Menu.AllIngredients(Menu.AvailableEntrees);
            Menu.AllIngredients(Menu.AvailableSides);
            Menu.AllIngredients(Menu.AvailableDrinks);
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
            Menu.AllIngredients(Menu.AvailableCombos);
            Menu.AllIngredients(Menu.AvailableEntrees);
            Menu.AllIngredients(Menu.AvailableSides);
            Menu.AllIngredients(Menu.AvailableDrinks);
            PossibleIngredientsHashSet = Menu.PossibleIngredients;
            if(Search != null)
            {
                Combos = Combos.Where(combo => combo.ToString().Contains(Search));
                Entrees = Entrees.Where(entree => entree.ToString().Contains(Search));
                Sides = Sides.Where(side => side.ToString().Contains(Search));
                Drinks = Drinks.Where(drink => drink.ToString().Contains(Search));
            }
            if(Filter.Count != 0)
            {
                Combos = Combos.Where(combo => combo is CretaceousCombo && Filter.Contains("Combo")); ;
                Entrees = Entrees.Where(entree => entree is Entree && Filter.Contains("Entree"));
                Sides = Sides.Where(side => side is Side && Filter.Contains("Side"));
                Drinks = Drinks.Where(drink => drink is Drink && Filter.Contains("Drink"));
            }
            if(Ingredients.Count != 0)
            {
                Combos = Combos.Where(combo =>
                {
                    bool keep = false;
                    for(int i = 0; i < Ingredients.Count; i++)
                    {
                        if (combo.Ingredients.Contains(Ingredients[i]))
                        {
                            keep = true;
                        }
                    }
                    return keep;
                });
                Entrees = Entrees.Where(entree =>
                {
                    bool keep = false;
                    for (int i = 0; i < Ingredients.Count; i++)
                    {
                        if (entree.Ingredients.Contains(Ingredients[i]))
                        {
                            keep = true;
                        }
                    }
                    return keep;
                });
                Sides = Sides.Where(side =>
                {
                    bool keep = false;
                    for (int i = 0; i < Ingredients.Count; i++)
                    {
                        if (side.Ingredients.Contains(Ingredients[i]))
                        {
                            keep = true;
                        }
                    }
                    return keep;
                });
                Drinks = Drinks.Where(drink =>
                {
                    bool keep = false;
                    for (int i = 0; i < Ingredients.Count; i++)
                    {
                        if (drink.Ingredients.Contains(Ingredients[i]))
                        {
                            keep = true;
                        }
                    }
                    return keep;
                });
            }
            if(MinimumPrice != null)
            {
                Combos = Combos.Where(combo => combo.Price >= MinimumPrice);
                Entrees = Entrees.Where(entree => entree.Price >= MinimumPrice);
                Sides = Sides.Where(side => side.Price >= MinimumPrice);
                Drinks = Drinks.Where(drink => drink.Price >= MinimumPrice);
            }
            if(MaximumPrice != null)
            {
                Combos = Combos.Where(combo => combo.Price <= MaximumPrice);
                Entrees = Entrees.Where(entree => entree.Price <= MaximumPrice);
                Sides = Sides.Where(side => side.Price <= MaximumPrice);
                Drinks = Drinks.Where(drink => drink.Price <= MaximumPrice);
            }
        }
    }
}