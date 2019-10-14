/* DrinkSelection.xaml
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Boolean to tell if the tyrannotea button was clicked
        /// </summary>
        private bool TyrannoteaButton = false;
        /// <summary>
        /// Boolean to tell if the jurassic java button was clicked
        /// </summary>
        private bool JurassicJavaButton = false;
        /// <summary>
        /// Boolean to tell if the water button was clicked
        /// </summary>
        private bool WaterButton = false;
        /// <summary>
        /// Boolean to tell if the sodasaurus button was clicked
        /// </summary>
        private bool SodasaurusButton = false;
        /// <summary>
        /// Creates a new button for the lemon ingredient
        /// </summary>
        private Button uxLemon = new Button();
        /// <summary>
        /// Creates a new button for the sweet ingredient
        /// </summary>
        private Button uxSweet = new Button();
        /// <summary>
        /// Creates a new button for decaf coffee
        /// </summary>
        private Button uxDecaf = new Button();
        /// <summary>
        /// Creates a new button for the cream ingredient
        /// </summary>
        private Button uxCream = new Button();
        /// <summary>
        /// Creates a new button to go to the flavor selection page
        /// </summary>
        private Button uxFlavor = new Button();
        /// <summary>
        /// Initializes and runs the page when called
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the sodasaurus button and disables and removes other buttons if something else was clicked
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectSodasaurus(object sender, RoutedEventArgs args)
        {
            if(TyrannoteaButton || JurassicJavaButton || WaterButton)
            {
                drinkGrid.Children.Remove(uxLemon);
                drinkGrid.Children.Remove(uxSweet);
                drinkGrid.Children.Remove(uxDecaf);
                drinkGrid.Children.Remove(uxCream);

            }
            uxFlavor.Content = "Flavor";
            
            Grid.SetColumn(uxFlavor, 0);
            Grid.SetRow(uxFlavor, 1);
            drinkGrid.Children.Add(uxFlavor);
            SodasaurusButton = true;
            uxFlavor.Click += new RoutedEventHandler(SelectFlavor);
        }
        /// <summary>
        /// Handles the tyrannotea button and disables and removes other buttons if something else was clicked
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectTyrannotea(object sender, RoutedEventArgs args)
        {
            if (SodasaurusButton || JurassicJavaButton || WaterButton)
            {
                drinkGrid.Children.Remove(uxFlavor);
                drinkGrid.Children.Remove(uxSweet);
                drinkGrid.Children.Remove(uxDecaf);
                drinkGrid.Children.Remove(uxCream);
                drinkGrid.Children.Remove(uxLemon);

            }
            uxSweet.Content = "Sweet";
            uxLemon.Content = "Lemon";

            Grid.SetColumn(uxSweet, 3);
            Grid.SetRow(uxSweet, 1);
            Grid.SetColumn(uxLemon, 3);
            Grid.SetRow(uxLemon, 2);
            drinkGrid.Children.Add(uxSweet);
            drinkGrid.Children.Add(uxLemon);
            TyrannoteaButton = true;
            
        }
        /// <summary>
        /// Handles the jurassic java button and disables and removes other buttons if something else was clicked
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectJurassicJava(object sender, RoutedEventArgs args)
        {
            if (SodasaurusButton || TyrannoteaButton || WaterButton)
            {
                drinkGrid.Children.Remove(uxFlavor);
                drinkGrid.Children.Remove(uxSweet);
                drinkGrid.Children.Remove(uxDecaf);
                drinkGrid.Children.Remove(uxCream);
                drinkGrid.Children.Remove(uxLemon);

            }
            uxCream.Content = "Cream";
            uxDecaf.Content = "Decaf";

            Grid.SetColumn(uxCream, 0);
            Grid.SetRow(uxCream, 1);
            Grid.SetColumn(uxDecaf, 0);
            Grid.SetRow(uxDecaf, 2);
            drinkGrid.Children.Add(uxCream);
            drinkGrid.Children.Add(uxDecaf);
            JurassicJavaButton = true;
        }
        /// <summary>
        /// Handles the water button and disables and removes other buttons if something else was clicked
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectWater(object sender, RoutedEventArgs args)
        {
            if (SodasaurusButton || JurassicJavaButton || TyrannoteaButton)
            {
                drinkGrid.Children.Remove(uxFlavor);
                drinkGrid.Children.Remove(uxSweet);
                drinkGrid.Children.Remove(uxDecaf);
                drinkGrid.Children.Remove(uxCream);
                drinkGrid.Children.Remove(uxLemon);

            }
            uxLemon.Content = "Lemon";

            Grid.SetColumn(uxLemon, 3);
            Grid.SetRow(uxLemon, 2);
            drinkGrid.Children.Add(uxLemon);
            WaterButton = true;
        }
        /// <summary>
        /// Handles the flavor button and navigates it to the flavor selection page
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
    }
}
