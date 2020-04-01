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
        public TransactionControl()
        {
            InitializeComponent();
            CashDrawer drawer = new CashDrawer();
        }

        private void PayByCardButtonClicked(object sender, RoutedEventArgs e)
        {
            var cardTerminal = new CardTerminal();
            double total = Convert.ToDouble(tbTotal.Text.Substring(1));
            ResultCode result = cardTerminal.ProcessTransaction(total);
            TextBlock output = new TextBlock();
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

        }      
    }
}
