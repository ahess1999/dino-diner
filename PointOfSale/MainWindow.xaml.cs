/* MainWindow.xaml
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Intializes and runs the program
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Order order = new Order();
            DataContext = order;
            OrderUI.Navigate(new MenuCategorySelection());
            OrderInterface.NavigationService = OrderUI.NavigationService;
        }
        /// <summary>
        /// Updates the Order on the side whenever there is a new update for the current order
        /// </summary>
        private void PassDataContentToPage()
        {
            if(OrderUI.Content is Page page)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }
        /// <summary>
        /// Changes the data context of the page whenever a load is completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassDataContentToPage();
        }
        /// <summary>
        /// Changes the data context on the page whenever a change is invoked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassDataContentToPage();
        }
        /// <summary>
        /// Back button to return to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnReturnToCategorySelections(object sender, RoutedEventArgs e)
        {
            OrderUI.NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
