/* CustomizeDinoNuggets.xaml
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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        /// <summary>
        /// Private backing variable
        /// </summary>
        private DinoNuggets dn;
        /// <summary>
        /// Constructor
        /// </summary>
        public CustomizeDinoNuggets(DinoNuggets dn)
        {
            InitializeComponent();
            this.dn = dn;
        }
        /// <summary>
        /// Event handler for adding nuggets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddNugget(object sender, RoutedEventArgs e)
        {
            dn.AddNugget();
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
