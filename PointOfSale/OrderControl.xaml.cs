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

            //Item/Order click events
            ItemSelectionButton.Click += ItemSelectionButton_Click;
            CancelOrderButton.Click += CancelOrderButton_Click;
            CompleteOrderButton.Click += CompleteOrderButton_Click;
        }

        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }

        /// <summary>
        /// Event for when the Item Selection Button is selected, currently has not function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// Event for when the Cancel Order Button is selected, creates a new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    this.DataContext = new Order();
                }
            }
            //this.DataContext = new Order();
        }
    }
}
