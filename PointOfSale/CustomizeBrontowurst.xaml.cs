/* CustomizeBrontowurst.xaml.cs
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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        /// <summary>
        /// Backing variable
        /// </summary>
        private Brontowurst b;
        /// <summary>
        /// Constructor
        /// </summary>
        public CustomizeBrontowurst(Brontowurst b)
        {
            InitializeComponent();
            this.b = b;
        }
        /// <summary>
        /// Event handler for holding bun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            this.b.HoldBun();
        }
        /// <summary>
        /// Event handler for holding peppers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeppers(object sender, RoutedEventArgs e)
        {
            this.b.HoldPeppers();
        }
        /// <summary>
        /// Event handler for holding onions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnions(object sender, RoutedEventArgs e)
        {
            this.b.HoldOnion();
        }
        /// <summary>
        /// Event handler for diggity done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDiggityDone(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
