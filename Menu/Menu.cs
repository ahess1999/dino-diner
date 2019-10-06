/* Menu.cs
 * Author: Austin Hess
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that adds and displays the entire menu
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Adds all menu items to a list
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                AvailableMenuItems.Add(new Brontowurst());
                AvailableMenuItems.Add(new DinoNuggets());
                AvailableMenuItems.Add(new PrehistoricPBJ());
                AvailableMenuItems.Add(new PterodactylWings());
                AvailableMenuItems.Add(new SteakosaurusBurger());
                AvailableMenuItems.Add(new TRexKingBurger());
                AvailableMenuItems.Add(new VelociWrap());
                AvailableMenuItems.Add(new Fryceritops());
                AvailableMenuItems.Add(new MeteorMacAndCheese());
                AvailableMenuItems.Add(new MezzorellaSticks());
                AvailableMenuItems.Add(new Triceritots());
                AvailableMenuItems.Add(new JurassicJava());
                AvailableMenuItems.Add(new Sodasaurus());
                AvailableMenuItems.Add(new Tyrannotea());
                AvailableMenuItems.Add(new Water());
                AvailableMenuItems.Add(new CretaceousCombo(new Brontowurst()));
                AvailableMenuItems.Add(new CretaceousCombo(new DinoNuggets()));
                AvailableMenuItems.Add(new CretaceousCombo(new PrehistoricPBJ()));
                AvailableMenuItems.Add(new CretaceousCombo(new PterodactylWings()));
                AvailableMenuItems.Add(new CretaceousCombo(new SteakosaurusBurger()));
                AvailableMenuItems.Add(new CretaceousCombo(new TRexKingBurger()));
                AvailableMenuItems.Add(new CretaceousCombo(new VelociWrap()));
                return AvailableMenuItems;
            }
        }
        /// <summary>
        /// Adds all entrees to a list
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                AvailableMenuItems.Add(new Brontowurst());
                AvailableMenuItems.Add(new DinoNuggets());
                AvailableMenuItems.Add(new PrehistoricPBJ());
                AvailableMenuItems.Add(new PterodactylWings());
                AvailableMenuItems.Add(new SteakosaurusBurger());
                AvailableMenuItems.Add(new TRexKingBurger());
                AvailableMenuItems.Add(new VelociWrap());
                return AvailableEntrees;
            }
        }
        /// <summary>
        /// Adds all sides to a list
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                AvailableMenuItems.Add(new Fryceritops());
                AvailableMenuItems.Add(new MeteorMacAndCheese());
                AvailableMenuItems.Add(new MezzorellaSticks());
                AvailableMenuItems.Add(new Triceritots());
                return AvailableSides;
            }
        }
        /// <summary>
        /// Adds all drinks to a list
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                AvailableMenuItems.Add(new Triceritots());
                AvailableMenuItems.Add(new JurassicJava());
                AvailableMenuItems.Add(new Sodasaurus());
                AvailableMenuItems.Add(new Tyrannotea());
                AvailableMenuItems.Add(new Water());
                return AvailableDrinks;
            }
        }
        /// <summary>
        /// Adds all combos to a list
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                AvailableMenuItems.Add(new CretaceousCombo(new Brontowurst()));
                AvailableMenuItems.Add(new CretaceousCombo(new DinoNuggets()));
                AvailableMenuItems.Add(new CretaceousCombo(new PrehistoricPBJ()));
                AvailableMenuItems.Add(new CretaceousCombo(new PterodactylWings()));
                AvailableMenuItems.Add(new CretaceousCombo(new SteakosaurusBurger()));
                AvailableMenuItems.Add(new CretaceousCombo(new TRexKingBurger()));
                AvailableMenuItems.Add(new CretaceousCombo(new VelociWrap()));
                return AvailableCombos;
            }
        }
        /// <summary>
        /// Prints the entire menu
        /// </summary>
        /// <returns>The entire menu</returns>
        public override string ToString()
        {
            for(int i = 0; i <= AvailableMenuItems.Count; i++)
            {
                return AvailableMenuItems[i].ToString() + " \n";
            }
            return "";
        }
    }
}
