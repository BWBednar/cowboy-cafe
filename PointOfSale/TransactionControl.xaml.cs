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
        private static CashDrawer programDrawer = new CashDrawer();
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
                    //print receipt 
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

        private void PayByCashButtonClicked(object sender, RoutedEventArgs e)
        {
            //Hide the cancel and item selection buttons from view
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.CancelOrderButton.Visibility = Visibility.Hidden;
            orderControl.ItemSelectionButton.Visibility = Visibility.Hidden;

            PayByCashButton.IsEnabled = false;
            //Change the PaymentBorder 
            CashPaymentInformationControl display = new CashPaymentInformationControl();
            display.DataContext = programDrawer;
            PaymentBorder.Child = display;

            var control = this.FindAncestor<OrderControl>();
            var display2 = new CashPaymentInputControl();
            control.SummaryBorder.Child = display2;
        }      
    }
}
