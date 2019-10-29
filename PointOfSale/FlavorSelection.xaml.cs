/* FlavorSelection.xaml
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// Private variable for drink
        /// </summary>
        private Sodasaurus soda;
        /// <summary>
        /// Intializes and runs the page when called
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Intializes and runs the page when called
        /// </summary>
        public FlavorSelection(Sodasaurus s)
        {
            InitializeComponent();
            this.soda = s;
        }
        /// <summary>
        /// Displays cherry on the sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectCherry(object sender, RoutedEventArgs args)
        {
            if (soda is Sodasaurus s)
            {
                s.Flavor = SodasaurusFlavor.Cherry;
            }
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Displays chocolate on the sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectChocolate(object sender, RoutedEventArgs args)
        {
            if (soda is Sodasaurus s)
            {
                s.Flavor = SodasaurusFlavor.Chocolate;
            }
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Displays cola on the sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectCola(object sender, RoutedEventArgs args)
        {
            if (soda is Sodasaurus s)
            {
                s.Flavor = SodasaurusFlavor.Cola;
            }
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Displays lime on the sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectLime(object sender, RoutedEventArgs args)
        {
            if (soda is Sodasaurus s)
            {
                soda.Flavor = SodasaurusFlavor.Lime;
            }
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Displays orange on the sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectOrange(object sender, RoutedEventArgs args)
        {
            if (soda is Sodasaurus s)
            {
                s.Flavor = SodasaurusFlavor.Orange;
            }
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Displays root beer on the sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectRootBeer(object sender, RoutedEventArgs args)
        {
            if (soda is Sodasaurus s)
            {
                s.Flavor = SodasaurusFlavor.RootBeer;
            }
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Displays vanilla on the sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectVanilla(object sender, RoutedEventArgs args)
        {
            if (soda is Sodasaurus s)
            {
                s.Flavor = SodasaurusFlavor.Vanilla;
            }
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
