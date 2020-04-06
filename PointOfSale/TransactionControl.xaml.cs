/*
 * TransactionControl.xaml.cs
 * Author: Brandon Bednar
 * Purpose: Backing code for the TransactionControl control
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
using CowboyCafe.Extensions;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        /// <summary>
        /// Variable that will share the cash register information between different controls
        /// </summary>
        private static CashRegisterModelView cashRegisterModelView = new CashRegisterModelView();

        /// <summary>
        /// Variable that keeps track of the current instance do the CashPaymentInputControl for different methods
        /// </summary>
        private CashPaymentInputControl cashInputControl;

        /// <summary>
        /// Initialize the TransactionControl
        /// </summary>
        public TransactionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event for if the user selects Pay By Card
        /// </summary>
        /// <param name="sender">The button selected</param>
        /// <param name="e">Routed Event Args</param>
        private void PayByCardButtonClicked(object sender, RoutedEventArgs e)
        {
            var cardTerminal = new CardTerminal(); //New card terminal
            double total = Convert.ToDouble(tbTotal.Text.Substring(1));
            ResultCode result = cardTerminal.ProcessTransaction(total);
            TextBlock output = new TextBlock(); //The PaymentBorder will be filled with this textbox
            switch (result)
            {
                case ResultCode.Success:
                    PrintReceiptForCardTransaction();
                    var control = this.FindAncestor<OrderControl>();
                    control.DataContext = new Order();
                    control.CompleteOrderButton.Visibility = Visibility.Visible;
                    control.Container.Child = new MenuItemSelectionControl();
                    break;
                case ResultCode.CancelledCard:
                    output.Text = "The card has been cancelled.\nPlease try again.";
                    PaymentBorder.Child = output;
                    break;
                case ResultCode.InsufficentFunds:
                    output.Text = "The card has insufficient fund.\nPlease try again.";
                    PaymentBorder.Child = output;
                    break;
                case ResultCode.ReadError:
                    output.Text = "Error reading card.\nPlease try again.";
                    PaymentBorder.Child = output;
                    break;
                case ResultCode.UnknownErrror:
                    output.Text = "Unknown error reading card.\nPlease try again.";
                    PaymentBorder.Child = output;
                    break;
                default:
                    output.Text = "Error";
                    PaymentBorder.Child = output;
                    break;
            }
        }

        /// <summary>
        /// Helper method for dealing with the receipt output for a card transaction
        /// </summary>
        private void PrintReceiptForCardTransaction()
        {
            StringBuilder receiptInfo = new StringBuilder();

            //Get the Order information from OrderControl
            var orderControl = this.FindAncestor<OrderControl>();
            var order = orderControl.DataContext as Order;

            //Get the OrderNumber from the Order
            receiptInfo.Append("Order Number: " + order.OrderNumber.ToString() + "\n");

            //Get the current date and time for the receipt
            receiptInfo.Append("Order Taken On: " + DateTime.Now.ToString() + "\n\n");

            //Get the individual order items with price and the special instructions of the items (if any)
            receiptInfo.Append("Order Items:\n");
            foreach (IOrderItem item in order.Items)
            {
                receiptInfo.Append(item.GetType().Name.ToString() + "\t" + string.Format("{0:C}",item.Price) + "\n");
                if (item.SpecialInstructions.Count > 0) {
                    receiptInfo.Append("Item Special Instructions: \n");
                    foreach (string instruction in item.SpecialInstructions)
                    {
                        receiptInfo.Append("\t" + instruction + "\n");
                    }
                }
                receiptInfo.Append("\n");
            }

            //Get the subtotal, tax, and total
            receiptInfo.Append("Subtotal:\t" + string.Format("{0:C}", order.Subtotal) + "\n"
                + "Tax:\t" + string.Format("{0:C}", order.Tax) + "\n"
                + "Total Due:\t" + string.Format("{0:C}", order.Total) + "\n");

            //Indicate that the order was payed for with a card
            receiptInfo.Append("Total Payed Using Card\n\n\n");

            //Print the receipt
            ReceiptPrinter printer = new ReceiptPrinter();
            printer.Print(receiptInfo.ToString());
        }

        /// <summary>
        /// Click event for if the user selects Pay By Cash 
        /// </summary>
        /// <param name="sender">The button selected</param>
        /// <param name="e">Routed Event Args</param>
        private void PayByCashButtonClicked(object sender, RoutedEventArgs e)
        {
            //Hide the cancel and item selection buttons from view
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.CancelOrderButton.Visibility = Visibility.Hidden;
            orderControl.ItemSelectionButton.Visibility = Visibility.Hidden;

            //Hide the PayByCashButton and PayByCardButton
            PayByCashButton.Visibility = Visibility.Hidden;
            PayByCardButton.Visibility = Visibility.Hidden;

            //Change the PaymentBorder to a CashPaymentInformationControl with proper DataContext
            var paymentControl = new CashPaymentInformationControl();
            paymentControl.DataContext = cashRegisterModelView;
            PaymentBorder.Child = paymentControl;

            //Change the SummaryBorder of OrderControl and set its DataContext
            cashInputControl = new CashPaymentInputControl();
            cashInputControl.DataContext = cashRegisterModelView;
            orderControl.SummaryBorder.Child = cashInputControl;
        }
        
        /// <summary>
        /// Method to pass information from the CashPaymentInputControl to CashPaymentInformationControl
        /// </summary>
        /// <param name="coinsQs">The quantities of the coins entered</param>
        /// <param name="billsQs">The quantities of the billes entered</param>
        /// <returns>The currency amount of the denominations the user entered</returns>
        public double GetCashEnteredFromCashPaymentInputControl(out int[] coinsQs, out int[] billsQs)
        {
            double amount = cashInputControl.GetCashAmountEnteredForTransactionControl(out int[] coinsQuantities, out int[] billsQuantities);
            coinsQs = coinsQuantities;
            billsQs = billsQuantities;

            return amount;
        }

        /// <summary>
        /// Helper method to check if the amount entered by the user meets the total amount due
        /// </summary>
        /// <param name="amount">Currency amount entered by the user</param>
        /// <returns>Boolean result of if the amount entered is enough for the amount due</returns>
        public bool CheckIfCashEnteredFulfillsTotalDue(double amount)
        {
            double totalDue = Convert.ToDouble(tbTotal.Text.Substring(1));
            if (totalDue > amount) return false;
            else return true;
        }

        /// <summary>
        /// Helper method for updating denomination quantities
        /// </summary>
        /// <param name="coins">The quantities of the coins</param>
        /// <param name="bills">The quantities of the bills</param>
        public void UpdateDenominationValues(int[] coins, int[] bills)
        {
            //Add or Remove the coins from the instance of CashRegisterModelView
            cashRegisterModelView.Pennies += coins[0];
            cashRegisterModelView.Nickels += coins[1];
            cashRegisterModelView.Dimes += coins[2];
            cashRegisterModelView.Quarters += coins[3];
            cashRegisterModelView.HalfDollars += coins[4];
            cashRegisterModelView.Dollars += coins[5];

            //Add or Remove the bills from the instance of CashRegisterModelView
            cashRegisterModelView.Ones += bills[0];
            cashRegisterModelView.Twos += bills[1];
            cashRegisterModelView.Fives += bills[2];
            cashRegisterModelView.Tens += bills[3];
            cashRegisterModelView.Twenties += bills[4];
            cashRegisterModelView.Fifties += bills[5];
            cashRegisterModelView.Hundreds += bills[6];
        }

        /// <summary>
        /// Helper method for if the text above the CashPaymentInputControl needs to be
        /// editted depending on how much money the user has inputted before trying to
        /// complete the transaction
        /// </summary>
        /// <param name="directions">Boolean value for if the amount entered was enough</param>
        public void ChangePaymentInformationPrompt(bool directions)
        {
            if (directions)
            {
                cashInputControl.tbDirections.Text = "Enter Denominations and Quantities";
                cashInputControl.tbDirections2.Text = "of Cash Given";
            }
            else
            {
                cashInputControl.tbDirections.Text = "More Money Required for Purchase";
                cashInputControl.tbDirections.Foreground = Brushes.Red;
                cashInputControl.tbDirections2.Text = "";
            }
        }

        /// <summary>
        /// Helper method to get the amount of money due for the order
        /// </summary>
        /// <returns>The amount of money due for the order</returns>
        public double GetTotalDue()
        {
            return Convert.ToDouble(tbTotal.Text.Substring(1));
        }
    }
}
