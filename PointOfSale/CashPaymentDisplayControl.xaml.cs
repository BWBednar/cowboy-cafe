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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPaymentDisplayControl.xaml
    /// </summary>
    public partial class CashPaymentDisplayControl : UserControl
    {
        public CashPaymentDisplayControl()
        {
            InitializeComponent();
        }

        public void CompleteCashPaymentButtonClicked(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Click event for the Cancel Cash Payment button.
        /// This event will return the display to having the OrderControlSummary in 
        /// the far right of the screen and will clear the view of the PaymentBorder from
        /// the TranscationControl.
        /// </summary>
        /// <param name="sender">The button selected</param>
        /// <param name="e">Routed Event Args</param>
        public void CancelCashPaymentButtonClicked(object sender, RoutedEventArgs e)
        {
            //get the previous TransactionControl and edit PaymentBorder and PayByCahsButton
            var transactionControl = this.FindAncestor<TransactionControl>();
            transactionControl.PaymentBorder.Child = null;
            transactionControl.PayByCashButton.IsEnabled = true;
            //get the previous OrderControl and edit the SummaryBorder 
            var orderControl = transactionControl.FindAncestor<OrderControl>();
            orderControl.SummaryBorder.Child = new OrderSummaryControl();
        }
    }
}
