/* CustomizeVelociWrap.xaml
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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        /// <summary>
        /// Backing variable
        /// </summary>
        private VelociWrap vw;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="vw"></param>
        public CustomizeVelociWrap(VelociWrap vw)
        {
            InitializeComponent();
            this.vw = vw;
        }
        /// <summary>
        /// Event Handler for hold dressing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldDressing(object sender, RoutedEventArgs e)
        {
            vw.HoldDressing();
        }
        /// <summary>
        /// Event Handler for hold lettuce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            vw.HoldLettuce();
        }
        /// <summary>
        /// Event Handler for hold cheese
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldCheese(object sender, RoutedEventArgs e)
        {
            vw.HoldCheese();
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
