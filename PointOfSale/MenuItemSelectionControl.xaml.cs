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
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        

        /// <summary>
        /// The interactions of the OrderControl with PointOfSale
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            

            //Entree click events
            AddCowpokeChiliButton.Click += OnItemAddButtonClicked; // AddCowpokeChiliButtonClicked;
            AddRustlersRibsButton.Click += OnItemAddButtonClicked; // AddRustlersRibsButtonClicked;
            AddPecosPulledPorkButton.Click += OnItemAddButtonClicked;//AddPecosPulledPorkButtonClicked;
            AddTrailBurgerButton.Click += OnItemAddButtonClicked; //AddTrailBurgerButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnItemAddButtonClicked; // AddDakotaDoubleBurgerButtonClicked;
            AddTexasTripleBurgerButton.Click += OnItemAddButtonClicked; // AddTexasTripleBurgerButtonClicked;
            AddAngryChickenButton.Click += OnItemAddButtonClicked;// AddAngryChickenButtonClicked;

            //Side click events
            AddChiliCheeseFriesButton.Click += OnItemAddButtonClicked;// AddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += OnItemAddButtonClicked;// AddCornDodgersButtonClicked;
            AddPanDeCampoButton.Click += OnItemAddButtonClicked;// AddPanDeCampoButtonClicked;
            AddBakedBeansButton.Click += OnItemAddButtonClicked;// AddBakedBeansButtonClicked;

            //Drink click events
            AddJerkedSodaButton.Click += OnItemAddButtonClicked;// AddJerkedSodaButtonClicked;
            AddTexasTeaButton.Click += OnItemAddButtonClicked;// AddTexasTeaButtonClicked;
            AddCowboyCoffeeButton.Click += OnItemAddButtonClicked;// AddCowboyCoffeeButtonClicked;
            AddWaterButton.Click += OnItemAddButtonClicked;// AddWaterButtonClicked;


        }

        public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "AngryChicken":
                            order.Add(new AngryChicken());
                            orderControl.SwapScreen(new CustomizeAngryChicken());
                            break;
                        case "CowpokeChili":
                            order.Add(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "RustlersRibs":
                            order.Add(new RustlersRibs());
                            orderControl.SwapScreen(new CustomizeRustlersRibs());
                            break;
                        case "PecosPulledPork":
                            order.Add(new PecosPulledPork());
                            orderControl.SwapScreen(new CustomizePecosPulledPork());
                            break;
                        case "TrailBurger":
                            order.Add(new TrailBurger());
                            orderControl.SwapScreen(new CustomizeTrailBurger());
                            break;
                        case "DakotaDoubleBurger":
                            order.Add(new DakotaDoubleBurger());
                            orderControl.SwapScreen(new CustomizeDakotaDoubleBurger());
                            break;
                        case "TexasTripleBurger":
                            order.Add(new TexasTripleBurger());
                            orderControl.SwapScreen(new CustomizeTexasTripleBurger());
                            break;
                        case "ChiliCheeseFries":
                            order.Add(new ChiliCheeseFries());
                            orderControl.SwapScreen(new CustomizeChiliCheeseFries());
                            break;
                        case "CornDodgers":
                            order.Add(new CornDodgers());
                            orderControl.SwapScreen(new CustomizeCornDodgers());
                            break;
                        case "PanDeCampo":
                            order.Add(new PanDeCampo());
                            orderControl.SwapScreen(new CustomizePanDeCampo());
                            break;
                        case "BakedBeans":
                            order.Add(new BakedBeans());
                            orderControl.SwapScreen(new CustomizeBakedBeans());
                            break;
                        case "CowboyCoffee":
                            order.Add(new CowboyCoffee());
                            orderControl.SwapScreen(new CustomizeCowboyCoffee());
                            break;
                        case "JerkedSoda":
                            order.Add(new JerkedSoda());
                            orderControl.SwapScreen(new CustomizeJerkedSoda());
                            break;
                        case "TexasTea":
                            order.Add(new TexasTea());
                            orderControl.SwapScreen(new CustomizeTexasTea());
                            break;
                        case "Water":
                            order.Add(new Water());
                            orderControl.SwapScreen(new CustomizeWater());
                            break;

                    }
                }
            }

            /*
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
            }
            */

        }
    }
}

