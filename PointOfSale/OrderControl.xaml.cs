/*
 * OrderControl.xaml.cs
 * Author: Brandon Bednar
 * Purpose: Backing code for the OrderControl control
 */

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
        /// OrderControl functionality
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();

            var data = new Order();
            DataContext = data;
        }

        /// <summary>
        /// Method that passes an enum change in an item to the order
        /// </summary>
        public void ItemChange()
        {
            if (DataContext is Order order)
            {
                order.NotifyItemChange();
            }
        }

        /// <summary>
        /// Method that changes the screen that the user is able to interact with
        /// </summary>
        /// <param name="element">The element used to change screens</param>
        public void SwapScreen(FrameworkElement element)
        {
            //If the user is being sent to the TransactionControl, the entire control changes
            if (element.GetType().Name.Equals("TransactionControl"))
            {
                OrderControlScreen.Child = element;
            }
            else Container.Child = element;
        }

        /// <summary>
        /// Method that sends the Point of Sale to a customization screen for the item being editted after
        /// it had been added to the order already
        /// </summary>
        /// <param name="item">The item being editted</param>
        public void ReturnToItemScreen(IOrderItem item)
        {
            //Set the DataContext to a variable and make sure the value is not null
            var order = DataContext as Order;
            if (order == null) throw new Exception("Datacontext expected to be an order instance");

            //Create a variable for the customization control to go to and set its value based on item
            FrameworkElement screen = null;
            switch (item.GetType().Name)
            {
                case "AngryChicken":
                    screen = new CustomizeAngryChicken();
                    break;
                case "CowpokeChili":
                    screen = new CustomizeCowpokeChili();
                    break;
                case "RustlersRibs":
                    screen = new CustomizeRustlersRibs();
                    break;
                case "PecosPulledPork":
                    screen = new CustomizePecosPulledPork();
                    break;
                case "TrailBurger":
                    screen = new CustomizeTrailBurger();
                    break;
                case "DakotaDoubleBurger":
                    screen = new CustomizeDakotaDoubleBurger();
                    break;
                case "TexasTripleBurger":
                    screen = new CustomizeTexasTripleBurger();
                    break;
                case "ChiliCheeseFries":
                    screen = new CustomizeChiliCheeseFries();
                    break;
                case "CornDodgers":
                    screen = new CustomizeCornDodgers();
                    break;
                case "PanDeCampo":
                    screen = new CustomizePanDeCampo();
                    break;
                case "BakedBeans":
                    screen = new CustomizeBakedBeans();
                    break;
                case "CowboyCoffee":
                    screen = new CustomizeCowboyCoffee();
                    break;
                case "JerkedSoda":
                    screen = new CustomizeJerkedSoda();
                    break;
                case "TexasTea":
                    screen = new CustomizeTexasTea();
                    break;
                case "Water":
                    screen = new CustomizeWater();
                    break;
                default:
                    screen = null;
                    break;
            }

            //If screen was set to a value, go to that control
            if (screen != null)
            {
                screen.DataContext = item;
                SwapScreen(screen);
            }
        }

        /// <summary>
        /// Method that tells the Order in DataContext to delete the item from the Order
        /// </summary>
        /// <param name="item">The item to be deleted from Order</param>
        public void DeleteOrderControlItem(IOrderItem item)
        {
            //Set the DataContext to a variable and make sure the value is not null
            var order = DataContext as Order;
            if (order == null) throw new Exception("Datacontext expected to be an order instance");

            order.Remove(item);
        }

        /// <summary>
        /// Event for when the Item Selection Button is selected, currently has not function
        /// </summary>
        /// <param name="sender">The button being selected</param>
        /// <param name="e">The event args</param>
        private void ItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// Event for when the Cancel Order Button is selected, creates a new order
        /// </summary>
        /// <param name="sender">The button being selected</param>
        /// <param name="e">The event args</param>
        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    this.DataContext = new Order();
                }
            }
        }

        /// <summary>
        /// Event for when the Complete Order Button is selected, creates a new order
        /// </summary>
        /// <param name="sender">The button being selected</param>
        /// <param name="e">The event args</param>
        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    FrameworkElement transactionScreen = new TransactionControl();
                    transactionScreen.DataContext = data;
                    SwapScreen(transactionScreen);
                }
            }
        }
    }
}
