/* CustomizeCombo.xaml
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// Initializes and runs the wpf
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }
        /// <summary>
        /// Navigates to the new page based on the button selected
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
