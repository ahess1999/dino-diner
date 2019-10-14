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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
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
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectVelociWrap(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

    }
}
