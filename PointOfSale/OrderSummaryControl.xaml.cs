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
        /// Method that gets the item selected from the OrderSumarryControl and goes to that item's control
        /// </summary>
        /// <param name="sender">The item selected</param>
        /// <param name="e">The SelectionChangedEventArgs</param>
        void ListBoxItemSelected(object sender, SelectionChangedEventArgs e)
        {
            var item = ((sender as ListBox).SelectedItem as IOrderItem);
            OrderControl control = this.FindAncestor<OrderControl>();
            if (item is IOrderItem)
            {
                control.ReturnToPreviousScreen(item);
            }
        }

        public void RemoveItemClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
