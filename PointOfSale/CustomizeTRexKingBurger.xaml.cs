/* CustomizeTRexKingBurger.xaml
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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        /// <summary>
        /// Private backing variables
        /// </summary>
        private TRexKingBurger tb;
        /// <summary>
        /// Constructor
        /// </summary>
        public CustomizeTRexKingBurger(TRexKingBurger tb)
        {
            InitializeComponent();
            this.tb = tb;
        }
        /// <summary>
        /// Event Handler for Hold Bun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            tb.HoldBun();
        }
        /// <summary>
        /// Event Handler for Hold Lettuce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            tb.HoldLettuce();
        }
        /// <summary>
        /// Event Handler for Hold Tomato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldTomato(object sender, RoutedEventArgs e)
        {
            tb.HoldTomato();
        }
        /// <summary>
        /// Event Handler for Hold Pickle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            tb.HoldPickle();
        }
        /// <summary>
        /// Event Handler for Hold Ketchup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            tb.HoldKetchup();
        }
        /// <summary>
        /// Event Handler for Hold Mustard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            tb.HoldMustard();
        }
        /// <summary>
        /// Event Handler for Hold Mayo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs e)
        {
            tb.HoldMayo();
        }
        /// <summary>
        /// Event Handler for Hold Onions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldOnions(object sender, RoutedEventArgs e)
        {
            tb.HoldOnion();
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
