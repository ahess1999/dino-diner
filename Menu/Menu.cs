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
            for(int i = 0; i <= AvailableMenuItems.Count; i++)
            {
                return AvailableMenuItems[i].ToString() + " \n";
            }
            return "";
        }
    }
}
