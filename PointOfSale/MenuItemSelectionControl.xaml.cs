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
            AddCowpokeChiliButton.Click += OnItemAddButtonClicked; 
            AddRustlersRibsButton.Click += OnItemAddButtonClicked; 
            AddPecosPulledPorkButton.Click += OnItemAddButtonClicked;
            AddTrailBurgerButton.Click += OnItemAddButtonClicked; 
            AddDakotaDoubleBurgerButton.Click += OnItemAddButtonClicked; 
            AddTexasTripleBurgerButton.Click += OnItemAddButtonClicked; 
            AddAngryChickenButton.Click += OnItemAddButtonClicked;

            //Side click events
            AddChiliCheeseFriesButton.Click += OnItemAddButtonClicked;
            AddCornDodgersButton.Click += OnItemAddButtonClicked;
            AddPanDeCampoButton.Click += OnItemAddButtonClicked;
            AddBakedBeansButton.Click += OnItemAddButtonClicked;

            //Drink click events
            AddJerkedSodaButton.Click += OnItemAddButtonClicked;
            AddTexasTeaButton.Click += OnItemAddButtonClicked;
            AddCowboyCoffeeButton.Click += OnItemAddButtonClicked;
            AddWaterButton.Click += OnItemAddButtonClicked;


        }

        /// <summary>
        /// Determines which menu item to add to order while also sending the user
        /// to the selection controls for each menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            var entree = new AngryChicken();
                            var screen = new CustomizeAngryChicken();
                            AddItemAndOpenCustimizationScreen(entree, screen);
                            break;
                        case "CowpokeChili":
                            var entree2 = new CowpokeChili();
                            var screen2 = new CustomizeCowpokeChili();
                            AddItemAndOpenCustimizationScreen(entree2, screen2);
                            break;
                        case "RustlersRibs":
                            var entree3 = new RustlersRibs();
                            var screen3 = new CustomizeRustlersRibs();
                            AddItemAndOpenCustimizationScreen(entree3, screen3);
                            break;
                        case "PecosPulledPork":
                            var entree4 = new PecosPulledPork();
                            var screen4 = new CustomizePecosPulledPork();
                            AddItemAndOpenCustimizationScreen(entree4, screen4);
                            break;
                        case "TrailBurger":
                            var entree5 = new TrailBurger();
                            var screen5 = new CustomizeTrailBurger();
                            AddItemAndOpenCustimizationScreen(entree5, screen5);
                            break;
                        case "DakotaDoubleBurger":
                            var entree6 = new DakotaDoubleBurger();
                            var screen6 = new CustomizeDakotaDoubleBurger();
                            AddItemAndOpenCustimizationScreen(entree6, screen6);
                            break;
                        case "TexasTripleBurger":
                            var entree7 = new TexasTripleBurger();
                            var screen7 = new CustomizeTexasTripleBurger();
                            AddItemAndOpenCustimizationScreen(entree7, screen7);
                            break;
                        case "ChiliCheeseFries":
                            var entree8 = new ChiliCheeseFries();
                            var screen8 = new CustomizeChiliCheeseFries();
                            AddItemAndOpenCustimizationScreen(entree8, screen8);
                            break;
                        case "CornDodgers":
                            var entree9 = new CornDodgers();
                            var screen9 = new CustomizeCornDodgers();
                            AddItemAndOpenCustimizationScreen(entree9, screen9);
                            break;
                        case "PanDeCampo":
                            var entree10 = new PanDeCampo();
                            var screen10 = new CustomizePanDeCampo();
                            AddItemAndOpenCustimizationScreen(entree10, screen10);
                            break;
                        case "BakedBeans":
                            var entree11 = new BakedBeans();
                            var screen11 = new CustomizeBakedBeans();
                            AddItemAndOpenCustimizationScreen(entree11, screen11);
                            break;
                        case "CowboyCoffee":
                            var entree12 = new CowboyCoffee();
                            var screen12 = new CustomizeCowboyCoffee();
                            AddItemAndOpenCustimizationScreen(entree12, screen12);
                            break;
                        case "JerkedSoda":
                            var entree13 = new JerkedSoda();
                            var screen13 = new CustomizeJerkedSoda();
                            AddItemAndOpenCustimizationScreen(entree13, screen13);
                            break;
                        case "TexasTea":
                            var entree14 = new TexasTea();
                            var screen14 = new CustomizeTexasTea();
                            AddItemAndOpenCustimizationScreen(entree14, screen14);
                            break;
                        case "Water":
                            var entree15 = new Water();
                            var screen15 = new CustomizeWater();
                            AddItemAndOpenCustimizationScreen(entree15, screen15);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Helper method for adding the items to the order and opening the correct customization screen
        /// </summary>
        /// <param name="item">The item being added to the order</param>
        /// <param name="screen">The customization screen for the item</param>
        void AddItemAndOpenCustimizationScreen(IOrderItem item,FrameworkElement screen)
        {
            //Need to have an Order to add this item to
            var order = DataContext as Order;
            if (order == null) throw new Exception("Datacontext expected to be an order instance");

            //Not all OrderItems need to be customized
            if (screen != null)
            {
                //Need to have an OrderControl ancestor to load the customization screen
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An ancestor of OrderControl expected but not found");

                //Add the item to the customization screen and launch it
                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }
            //Add the item to the order
            order.Add(item);
        }
    }
}

