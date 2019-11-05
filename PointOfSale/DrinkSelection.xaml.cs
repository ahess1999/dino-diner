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
using DinoDiner.Menu;
using DDSize = DinoDiner.Menu.Size;

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
        /// Private variable for drink
        /// </summary>
        private Drink drink;
        /// <summary>
        /// Initializes and runs the page when called
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            drinkGrid.Children.Remove(uxLemon);
            drinkGrid.Children.Remove(uxSweet);
            drinkGrid.Children.Remove(uxDecaf);
            drinkGrid.Children.Remove(uxCream);
            drinkGrid.Children.Remove(uxFlavor);
        }

        /// <summary>
        /// Intializes and runs the page when called
        /// </summary>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
           if(drink is Sodasaurus s)
            {
                drinkGrid.Children.Remove(uxFlavor);
                drinkGrid.Children.Remove(uxLemon);
                drinkGrid.Children.Remove(uxSweet);
                drinkGrid.Children.Remove(uxDecaf);
                drinkGrid.Children.Remove(uxCream);
                uxFlavor.Content = "Flavor";
                uxFlavor.Click += new RoutedEventHandler(SelectFlavor);
                Grid.SetColumn(uxFlavor, 0);
                Grid.SetRow(uxFlavor, 1);
                if (SodasaurusButton == false)
                {
                    drinkGrid.Children.Add(uxFlavor);
                }
                SodasaurusButton = true;
            }
           if(drink is Tyrannotea t)
            {
                drinkGrid.Children.Remove(uxFlavor);
                drinkGrid.Children.Remove(uxSweet);
                drinkGrid.Children.Remove(uxLemon);
                drinkGrid.Children.Remove(uxDecaf);
                drinkGrid.Children.Remove(uxCream);
                uxSweet.Content = "Sweet";
                uxLemon.Content = "Lemon";
                uxSweet.Click += new RoutedEventHandler(OnSelectSweet);
                uxLemon.Click += new RoutedEventHandler(OnChangeLemon);
                Grid.SetColumn(uxSweet, 3);
                Grid.SetRow(uxSweet, 1);
                Grid.SetColumn(uxLemon, 3);
                Grid.SetRow(uxLemon, 2);
                if (TyrannoteaButton == false)
                {
                    drinkGrid.Children.Add(uxSweet);
                    drinkGrid.Children.Add(uxLemon);
                }
                TyrannoteaButton = true;
            }
           if(drink is JurassicJava j)
            {
                drinkGrid.Children.Remove(uxFlavor);
                drinkGrid.Children.Remove(uxSweet);
                drinkGrid.Children.Remove(uxLemon);
                drinkGrid.Children.Remove(uxDecaf);
                drinkGrid.Children.Remove(uxCream);
                uxCream.Content = "Cream";
                uxDecaf.Content = "Decaf";
                uxCream.Click += new RoutedEventHandler(OnSelectCream);
                uxDecaf.Click += new RoutedEventHandler(OnSelectDecaf);
                Grid.SetColumn(uxCream, 0);
                Grid.SetRow(uxCream, 1);
                Grid.SetColumn(uxDecaf, 0);
                Grid.SetRow(uxDecaf, 2);
                if (JurassicJavaButton == false)
                {
                    drinkGrid.Children.Add(uxCream);
                    drinkGrid.Children.Add(uxDecaf);
                }
                JurassicJavaButton = true;
            }
           if(drink is Water w)
            {
                drinkGrid.Children.Remove(uxFlavor);
                drinkGrid.Children.Remove(uxSweet);
                drinkGrid.Children.Remove(uxLemon);
                drinkGrid.Children.Remove(uxDecaf);
                drinkGrid.Children.Remove(uxCream);
                uxLemon.Content = "Lemon";
                uxLemon.Click += new RoutedEventHandler(OnChangeLemon);
                Grid.SetColumn(uxLemon, 3);
                Grid.SetRow(uxLemon, 2);
                if (WaterButton == false)
                {
                    drinkGrid.Children.Add(uxLemon);
                }
                WaterButton = true;
            }
        }
        /// <summary>
        /// Handles the sodasaurus button and disables and removes other buttons if something else was clicked
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        private void SelectSodasaurus(object sender, RoutedEventArgs args)
        {
            if (TyrannoteaButton || JurassicJavaButton || WaterButton)
            {
                drinkGrid.Children.Remove(uxLemon);
                drinkGrid.Children.Remove(uxSweet);
                drinkGrid.Children.Remove(uxDecaf);
                drinkGrid.Children.Remove(uxCream);

            }
            uxFlavor.Content = "Flavor";
            if (SodasaurusButton == false)
            {
                drinkGrid.Children.Add(uxFlavor);
            }
            Grid.SetColumn(uxFlavor, 0);
            Grid.SetRow(uxFlavor, 1);
            SodasaurusButton = true;
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                order.Add(drink);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        /// <summary>
        /// Handles the tyrannotea button and disables and removes other buttons if something else was clicked
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        private void SelectTyrannotea(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Add(drink);
            }
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
            if(TyrannoteaButton == false)
            {
                drinkGrid.Children.Add(uxSweet);
                drinkGrid.Children.Add(uxLemon);
            }
            TyrannoteaButton = true;
            uxSweet.Click += new RoutedEventHandler(OnSelectSweet);
            uxLemon.Click += new RoutedEventHandler(OnChangeLemon);
        }
        /// <summary>
        /// Handles the jurassic java button and disables and removes other buttons if something else was clicked
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        private void SelectJurassicJava(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                order.Add(drink);
            }
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
            uxCream.Click += new RoutedEventHandler(OnSelectCream);
            uxDecaf.Click += new RoutedEventHandler(OnSelectDecaf);
            Grid.SetColumn(uxCream, 0);
            Grid.SetRow(uxCream, 1);
            Grid.SetColumn(uxDecaf, 0);
            Grid.SetRow(uxDecaf, 2);
            if(JurassicJavaButton == false)
            {
                drinkGrid.Children.Add(uxCream);
                drinkGrid.Children.Add(uxDecaf);
            }
            JurassicJavaButton = true;
        }
        /// <summary>
        /// Handles the water button and disables and removes other buttons if something else was clicked
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        private void SelectWater(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Water();
                order.Add(drink);
            }
            if (SodasaurusButton || JurassicJavaButton || TyrannoteaButton)
            {
                drinkGrid.Children.Remove(uxFlavor);
                drinkGrid.Children.Remove(uxSweet);
                drinkGrid.Children.Remove(uxDecaf);
                drinkGrid.Children.Remove(uxCream);
                drinkGrid.Children.Remove(uxLemon);

            }
            uxLemon.Content = "Lemon";
            uxLemon.Click += new RoutedEventHandler(OnChangeLemon);
            Grid.SetColumn(uxLemon, 3);
            Grid.SetRow(uxLemon, 2);
            if(WaterButton == false)
            {
                drinkGrid.Children.Add(uxLemon);
            }
            WaterButton = true;
        }
        /// <summary>
        /// Handles the flavor button and navigates it to the flavor selection page
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            Sodasaurus soda = (Sodasaurus)drink;
            NavigationService.Navigate(new FlavorSelection(soda));
        }

        /// <summary>
        /// Displays the selected size of drink that is ordered
        /// </summary>
        /// <param name="sender">Reference to an object</param>
        /// <param name="args">Contains event data</param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
            NavigationService.GoBack();
        }
        /// <summary>
        /// Displays lemon on specific drinks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeLemon(object sender, RoutedEventArgs args)
        {
            if(drink is Water water)
            {
                water.AddLemon();
            }
            else
            {
                Tyrannotea tea = (Tyrannotea)drink;
                tea.AddLemon();
            }
        }
        /// <summary>
        /// Sends the user back to the MenuCategorySelection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ReturnToMenuSelection(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
        /// <summary>
        /// Displays sweet on the tryannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSweet(object sender, RoutedEventArgs args)
        {
            if(drink is Tyrannotea tea)
            {
                tea.AddSweetner();
            }
        }

        /// <summary>
        /// Displays decaf on the jurassic java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectDecaf(object sender, RoutedEventArgs args)
        {
            if (drink is JurassicJava java)
            {
                java.DecafJava();
            }
        }

        /// <summary>
        /// Displays cream on the jurassic java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectCream(object sender, RoutedEventArgs args)
        {
            if (drink is JurassicJava java)
            {
                java.LeaveSpaceForCream();
            }
        }
    }
}
