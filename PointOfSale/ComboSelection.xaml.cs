/* ComboSelection.xaml
 * Author: Austin Hess
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// Backing Variable
        /// </summary>
        private CretaceousCombo combo;
        /// <summary>
        /// Initializes and runs the form when called
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectBrontowurst(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                Brontowurst b = new Brontowurst();
                order.Add(b);
                NavigationService.Navigate(new CustomizeBrontowurst(b));
            }
        }
        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                DinoNuggets dn = new DinoNuggets();
                order.Add(dn);
                NavigationService.Navigate(new CustomizeDinoNuggets(dn));
            }
        }
        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                SteakosaurusBurger sb = new SteakosaurusBurger();
                order.Add(sb);
                NavigationService.Navigate(new CustomizeSteakosaurusburger(sb));
            }
        }
        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                TRexKingBurger tb = new TRexKingBurger();
                order.Add(tb);
                NavigationService.Navigate(new CustomizeTRexKingBurger(tb));
            }
        }
        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            }
        }
        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                PterodactylWings pw = new PterodactylWings();
                order.Add(pw);
            }
        }
        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                VelociWrap vw = new VelociWrap();
                order.Add(vw);
                NavigationService.Navigate(new CustomizeVelociWrap(vw));
            }
        }

        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void OnSelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }
        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void OnSelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Displays the selected size of side that is ordered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSizeToSmall(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Small;
        }
        /// <summary>
        /// Displays the selected size of side that is ordered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSizeToMedium(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Medium;
        }
        /// <summary>
        /// Displays the selected size of side that is ordered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSizeToLarge(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Large;
        }
    }
}
