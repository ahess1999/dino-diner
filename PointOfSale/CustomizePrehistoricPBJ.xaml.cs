/* CustomizePrehistoricPBJ.xaml
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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        /// <summary>
        /// Private variable to gold the pbj
        /// </summary>
        private PrehistoricPBJ pbj;
        /// <summary>
        /// Initializes and runs the page when called
        /// </summary>
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }
        /// <summary>
        /// Event handler for holding peanut butter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            this.pbj.HoldPeanutButter();
        }
        /// <summary>
        /// Event handler for holding jelly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            this.pbj.HoldJelly();
        }
        /// <summary>
        /// Event handler for the diggity done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDiggityDone(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
