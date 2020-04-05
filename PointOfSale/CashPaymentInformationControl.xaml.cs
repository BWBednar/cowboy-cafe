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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPaymentInformationControl.xaml
    /// </summary>
    public partial class CashPaymentInformationControl : UserControl
    {
        
        public CashPaymentInformationControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event for the Complete Cash Payment Button
        /// This event will get the denominations entered by the user for the 
        /// payment and then add them to the CashDrawer if the payment is enough.
        /// The CashChangeDisplayControl will then be shown if the payment was enough.
        /// </summary>
        /// <param name="sender">The button selected</param>
        /// <param name="e">Routed Event Args</param>
        private void CompleteCashPaymentButtonClicked(object sender, RoutedEventArgs e)
        {
            var transactionControl = this.FindAncestor<TransactionControl>();
            double amount = transactionControl.GetCashEnteredFromCashPaymentInputControl(out int[] coinsQuantities, out int[] billQuantities);

            //If the amount entered by the user meets the total amount due
            if (transactionControl.CheckIfCashEnteredFulfillsTotalDue(amount))
            {
                //Update model denomination values
                transactionControl.UpdateDenominationValues(coinsQuantities, billQuantities);
                //Change the CashPaymentInputControl to ChangeReturnDisplayControl
                ChangeReturnDisplayControl changeDisplay = new ChangeReturnDisplayControl();
                changeDisplay.DataContext = this.DataContext;
                var orderControl = transactionControl.FindAncestor<OrderControl>();
                orderControl.SummaryBorder.Child = changeDisplay;
                changeDisplay.CalculateChange(orderControl.GetTotalDueFromOrderControl(), amount);
            }
            else
            {
                //Prompt for more money to be entered
                transactionControl.ChangePaymentInformationPrompt(false);
            }
        }

        /// <summary>
        /// Click event for the Cancel Cash Payment button.
        /// This event will return the display to having the OrderControlSummary in 
        /// the far right of the screen and will clear the view of the PaymentBorder from
        /// the TranscationControl. Also, the Cancel and Item Selection Buttons are made
        /// visible again
        /// </summary>
        /// <param name="sender">The button selected</param>
        /// <param name="e">Routed Event Args</param>
        private void CancelCashPaymentButtonClicked(object sender, RoutedEventArgs e)
        {
            //get the previous TransactionControl and edit PaymentBorder, PayByCashButton and PayByCardButton
            var transactionControl = this.FindAncestor<TransactionControl>();
            transactionControl.PaymentBorder.Child = null;
            transactionControl.PayByCashButton.Visibility = Visibility.Visible;
            transactionControl.PayByCardButton.Visibility = Visibility.Visible;
            //get the previous OrderControl and edit the SummaryBorder and the previously hidden Cancel and Item Selection Buttons
            var orderControl = transactionControl.FindAncestor<OrderControl>();
            orderControl.SummaryBorder.Child = new OrderSummaryControl();
            orderControl.CancelOrderButton.Visibility = Visibility.Visible;
            orderControl.ItemSelectionButton.Visibility = Visibility.Visible;
            
        }
    }
}
