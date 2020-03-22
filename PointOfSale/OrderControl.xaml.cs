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
            Container.Child = element;
        }

        public void ReturnToPreviousScreen(IOrderItem item)
        {
            
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
                    this.DataContext = new Order();
                }
            }
        }
    }
}
