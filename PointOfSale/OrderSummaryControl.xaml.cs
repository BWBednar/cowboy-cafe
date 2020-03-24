/*
 * OrderSummaryControl.xaml.cs
 * Author: Brandon Bednar
 * Purpose: Backing code for the OrderSummaryControl control
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
using CowboyCafe.Extensions;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        /// <summary>
        /// Initialize OrderSummaryControl
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Selection event method that gets the item selected from the OrderSumarryControl and goes to that item's control
        /// </summary>
        /// <param name="sender">The item selected</param>
        /// <param name="e">The SelectionChangedEventArgs</param>
        void ListBoxItemSelected(object sender, SelectionChangedEventArgs e)
        {
            var item = ((sender as ListBox).SelectedItem as IOrderItem);
            OrderControl control = this.FindAncestor<OrderControl>();
            if (item is IOrderItem)
            {
                if (control is OrderControl)
                {
                    control.ReturnToItemScreen(item);
                }
            }
        }

        /// <summary>
        /// Click event for the delete button that passes the neccesary information to OrderControl to delete the selected item
        /// </summary>
        /// <param name="sender">The button selected</param>
        /// <param name="e">The RoutedEventArgs</param>
        public void RemoveItemClick(object sender, RoutedEventArgs e)
        {
            OrderControl control = this.FindAncestor<OrderControl>();
            if(control is OrderControl)
            {
                if (sender is Button button)
                {
                    control.DeleteOrderControlItem(button.DataContext as IOrderItem);
                }
            }
        }
    }
}
