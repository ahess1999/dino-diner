/* EntreeSelection.xaml
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// Private variable for entree
        /// </summary>
        private Entree entree;
        /// <summary>
        /// Initializes and runs the form when called
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Intializes and runs the page when called
        /// </summary>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            this.entree = entree;
        }

        /// <summary>
        /// Displays and adds Brontowurst to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst b = new Brontowurst();
                order.Add(b);
                NavigationService.Navigate(new CustomizeBrontowurst(b));
            }
        }

        /// <summary>
        /// Displays and adds Dino-Nuggets to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets dn = new DinoNuggets();
                order.Add(dn);
                NavigationService.Navigate(new CustomizeDinoNuggets(dn));
            }
        }

        /// <summary>
        /// Displays and adds Prehistoric PB&J to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            }
        }

        /// <summary>
        /// Displays and adds Pterodactyl Wings to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Displays and adds Steakosaurus Burger to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger s = new SteakosaurusBurger();
                order.Add(s);
                NavigationService.Navigate(new CustomizeSteakosaurusburger(s));
            }
        }

        /// <summary>
        /// Displays and adds T-Rex King Burger to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger tb = new TRexKingBurger();
                order.Add(tb);
                NavigationService.Navigate(new CustomizeTRexKingBurger(tb));
            }
        }

        /// <summary>
        /// Displays and adds Veloci-Wrap to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap vw = new VelociWrap();
                order.Add(vw);
                NavigationService.Navigate(new CustomizeVelociWrap(vw));
            }
        }

        /// <summary>
        /// Sends the user back to the MenuCategorySelection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ReturnToMenuSelection(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
