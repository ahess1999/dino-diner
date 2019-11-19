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
        /// Read-Only variable
        /// </summary>
        protected Menu menu;
        /// <summary>
        /// Menu items
        /// </summary>
        public Menu Menu { get { return menu; } }
        /// <summary>
        /// Constructor for Menu razor page
        /// </summary>
        public void OnGet()
        {
            menu = new Menu();
        }
    }
}