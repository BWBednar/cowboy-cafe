using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// The interactions of the OrderControl with PointOfSale
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();

            //Entree click events
            AddCowpokeChiliButton.Click += AddCowpokeChiliButtonClicked;
            AddRustlersRibsButton.Click += AddRustlersRibsButtonClicked;
            AddPecosPulledPorkButton.Click += AddPecosPulledPorkButtonClicked;
            AddTrailBurgerButton.Click += AddTrailBurgerButtonClicked;
            AddDakotaDoubleBurgerButton.Click += AddDakotaDoubleBurgerButtonClicked;
            AddTexasTripleBurgerButton.Click += AddTexasTripleBurgerButtonClicked;
            AddAngryChickenButton.Click += AddAngryChickenButtonClicked;

            //Side click events
            AddChiliCheeseFriesButton.Click += AddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += AddCornDodgersButtonClicked;
            AddPanDeCampoButton.Click += AddPanDeCampoButtonClicked;
            AddBakedBeansButton.Click += AddBakedBeansButtonClicked;

            //Drink click events
            AddJerkedSodaButton.Click += AddJerkedSodaButtonClicked;
            AddTexasTeaButton.Click += AddTexasTeaButtonClicked;
            AddCowboyCoffeeButton.Click += AddCowboyCoffeeButtonClicked;
            AddWaterButton.Click += AddWaterButtonClicked;
        }

        /// <summary>
        /// Click event for the Cowpoke Chili entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            CowpokeChili item = new CowpokeChili();
            if (DataContext is Order data)
            {
                data.Add(item);
            }
            //OrderListView.Items.Add(new RustlersRibs());

        }

        /// <summary>
        /// Click event for the Rustlers Ribs entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            RustlersRibs item = new RustlersRibs();
            if (DataContext is Order data)
            {
                data.Add(item);
            }
            //OrderListView.Items.Add(new RustlersRibs());
        }

        /// <summary>
        /// Click event for the Pecos Pulled Pork entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            PecosPulledPork item = new PecosPulledPork();
            if (DataContext is Order data)
            {
                data.Add(item);
            }
            //OrderListView.Items.Add(new PecosPulledPork());
        }

        /// <summary>
        /// Click event for the Trail Burger entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            TrailBurger item = new TrailBurger();
            if (DataContext is Order data)
            {
                data.Add(item);
            }
            // OrderListView.Items.Add(new TrailBurger());
        }

        /// <summary>
        /// Click event for the Dakota Double Burger entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            DakotaDoubleBurger item = new DakotaDoubleBurger();
            if (DataContext is Order data)
            {
                data.Add(item);
            }
            //OrderListView.Items.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// Click event for the Texas Triple Burger entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            TexasTripleBurger item = new TexasTripleBurger();
            if (DataContext is Order data)
            {
                data.Add(item);
            }
            //OrderListView.Items.Add(new TexasTripleBurger());
        }

        /// <summary>
        /// Click event for the Angry Chicken entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            AngryChicken item = new AngryChicken();
            if (DataContext is Order data)
            {
                data.Add(item);
            }
            //   OrderListView.Items.Add(new AngryChicken());
        }

        /// <summary>
        /// Click event for the Chili Cheese Fries side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            ChiliCheeseFries item = new ChiliCheeseFries();
            if (DataContext is Order data)
            {
                data.Add(item);
            }
            // OrderListView.Items.Add(new ChiliCheeseFries());
        }

        /// <summary>
        /// Click event for the Corn Dodgers side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            CornDodgers item = new CornDodgers();
            if (DataContext is Order data)
            {
                data.Add(item);
            }
            //OrderListView.Items.Add(new CornDodgers());
        }

        /// <summary>
        /// Click event for the Pan De Campo side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            PanDeCampo item = new PanDeCampo();
            if (DataContext is Order data)
            {
                data.Add(item);
            }
            //OrderListView.Items.Add(new PanDeCampo());
        }

        /// <summary>
        /// Click event for the Baked Beans side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            BakedBeans item = new BakedBeans();
            if (DataContext is Order data)
            {
                data.Add(item);
            }
            //OrderListView.Items.Add(new BakedBeans());
        }

        /// <summary>
        /// Click event for the Jerked Soda drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            JerkedSoda item = new JerkedSoda();
            if (DataContext is Order data)
            {
                data.Add(item);
            }
            //OrderListView.Items.Add(new JerkedSoda());
        }

        /// <summary>
        /// Click event for the Texas Tea drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            TexasTea item = new TexasTea();
            if (DataContext is Order data)
            {
                data.Add(item);
            }
            //OrderListView.Items.Add(new TexasTea());
        }

        /// <summary>
        /// Click event for the Cowboy Coffee drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            CowboyCoffee item = new CowboyCoffee();
            if (DataContext is Order data)
            {
                data.Add(item);
            }
            //OrderListView.Items.Add(new CowboyCoffee());
        }

        /// <summary>
        /// Click event for the Water drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            Water item = new Water();
            if (DataContext is Order data)
            {
                data.Add(item);
            }
            //OrderListView.Items.Add(new Water());
        }
    }
}
