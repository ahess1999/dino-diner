/* CustomizeSteakosaurusburger.xaml
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
    /// Interaction logic for CustomizeSteakosaurusburger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusburger : Page
    {
        /// <summary>
        /// Backing variable
        /// </summary>
        private SteakosaurusBurger sb;
        /// <summary>
        /// Constructor
        /// </summary>
        public CustomizeSteakosaurusburger(SteakosaurusBurger sb)
        {
            InitializeComponent();
            this.sb = sb;
        }

        /// <summary>
        /// Event Handler for Hold Bun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            sb.HoldBun();
        }

        /// <summary>
        /// Event Handler for Hold Pickle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            sb.HoldPickle();
        }
        /// <summary>
        /// Event Handler for Hold Ketchup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            sb.HoldKetchup();
        }
        /// <summary>
        /// Event Handler for Hold Mustard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            sb.HoldMustard();
        }

        /// <summary>
        /// Event Handler for diggity done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDiggityDone(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
