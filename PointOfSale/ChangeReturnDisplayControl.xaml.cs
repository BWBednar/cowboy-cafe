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
using CashRegister;
using CowboyCafe.Extensions;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ChangeReturnDisplayControl.xaml
    /// </summary>
    public partial class ChangeReturnDisplayControl : UserControl
    {
        public ChangeReturnDisplayControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method that sets the quantities of how much of each denomination 
        /// is needed to make proper change
        /// </summary>
        /// <param name="totalDue">The total of the order</param>
        /// <param name="amountPayed">The total of the cash given by the custome</param>
        public void CalculateChange(double totalDue, double amountPayed)
        {
            double change = amountPayed - totalDue;
            tbChangeDue.Text = string.Format("{0:C}", change);
            tbAmountPayed.Text = string.Format("{0:C}", amountPayed.ToString());
            var drawer = DataContext as CashRegisterModelView;

            //Get the quantity of each denomination for proper change
            while (change > 0.00)
            {
                if (change >= 100 && drawer.Hundreds > 0)
                {
                    
                        int value = Convert.ToInt32(tbHundredsDue.Text);
                        value += 1;
                        tbHundredsDue.Text = value.ToString();
                        change -= 100.00;
                    
                }
                else if (change >= 50 && drawer.Fifties > 0)
                {
                    
                        int value = Convert.ToInt32(tbFiftiesDue.Text);
                        value += 1;
                        tbFiftiesDue.Text = value.ToString();
                        change -= 50.00;
                    
                }
                else if (change >= 20 && drawer.Twenties > 0)
                {
                    
                        int value = Convert.ToInt32(tbTwentiesDue.Text);
                        value += 1;
                        tbTwentiesDue.Text = value.ToString();
                        change -= 20.00;
                    
                }
                else if (change >= 10 && drawer.Tens > 0)
                {
                    
                        int value = Convert.ToInt32(tbTensDue.Text);
                        value += 1;
                        tbTensDue.Text = value.ToString();
                        change -= 10.00;
                    
                }
                else if (change >= 5 && drawer.Fives > 0)
                {
                    
                        int value = Convert.ToInt32(tbFivesDue.Text);
                        value += 1;
                        tbFivesDue.Text = value.ToString();
                        change -= 5.00;
                    
                }
                else if (change >= 2 && drawer.Twos > 0)
                {
                    
                        int value = Convert.ToInt32(tbTwosDue.Text);
                        value += 1;
                        tbTwosDue.Text = value.ToString();
                        change -= 2.00;
                    
                }
                else if (change >= 1 && (drawer.Ones > 0 || drawer.Dollars > 0))
                {
                    if (drawer.Ones > 0)
                    {
                        int value = Convert.ToInt32(tbOnesDue.Text);
                        value += 1;
                        tbOnesDue.Text = value.ToString();
                        change -= 1.00;
                    }
                    else
                    {

                        int value = Convert.ToInt32(tbDollarCoinsDue.Text);
                        value += 1;
                        tbDollarCoinsDue.Text = value.ToString();
                        change -= 1.00;
                    }
                }
                else if (change >= 0.50 && drawer.HalfDollars > 0)
                {
                    
                        int value = Convert.ToInt32(tbHalfDollarsDue.Text);
                        value += 1;
                        tbHalfDollarsDue.Text = value.ToString();
                        change -= 0.50;
                    
                }
                else if (change >= 0.25 && drawer.Quarters > 0)
                {
                    
                        int value = Convert.ToInt32(tbQuartersDue.Text);
                        value += 1;
                        tbQuartersDue.Text = value.ToString();
                        change -= 0.25;
                    
                }
                else if (change >= 0.10 && drawer.Dimes > 0)
                {
                    
                        int value = Convert.ToInt32(tbDimesDue.Text);
                        value += 1;
                        tbDimesDue.Text = value.ToString();
                        change -= 0.10;
                    
                }
                else if (change >= 0.05 && drawer.Nickels > 0)
                {
                    
                        int value = Convert.ToInt32(tbNickelsDue.Text);
                        value += 1;
                        tbNickelsDue.Text = value.ToString();
                        change -= 0.05;
                    
                }
                else if (change >= 0.01 && drawer.Pennies > 0)
                {
                    
                        int value = Convert.ToInt32(tbPenniesDue.Text);
                        value += 1;
                        tbPenniesDue.Text = value.ToString();
                        change -= 0.01;
                    
                }
                else
                {
                    //deal with this later.
                }
                change = Math.Round(change, 2);
            }
        }

        /// <summary>
        /// Click event to dispense change
        /// </summary>
        /// <param name="sender">The button selected</param>
        /// <param name="e">Routed Event Args</param>
        private void DispenseChangeButtonClick(object sender, RoutedEventArgs e)
        {
            bool enoughChange = true;
            var drawer = DataContext as CashRegisterModelView;

            //Remove the quantities of the denominations, if possible
            if (Convert.ToInt32(tbHundredsDue.Text) > 0)
            { 
                if (drawer.Hundreds < Convert.ToInt32(tbHundredsDue.Text))
                {
                    enoughChange = false;
                }
                else drawer.Hundreds -= Convert.ToInt32(tbHundredsDue.Text);
            }
            if (Convert.ToInt32(tbFiftiesDue.Text) > 0)
            {
                if (drawer.Fifties < Convert.ToInt32(tbFiftiesDue.Text))
                {
                    enoughChange = false;
                }
                else drawer.Fifties -= Convert.ToInt32(tbFiftiesDue.Text);
            }
            if (Convert.ToInt32(tbTwentiesDue.Text) > 0)
            {
                if (drawer.Twenties < Convert.ToInt32(tbTwentiesDue.Text))
                {
                    enoughChange = false;
                }
                else drawer.Twenties -= Convert.ToInt32(tbTwentiesDue.Text);
            }
            if (Convert.ToInt32(tbTensDue.Text) > 0)
            {
                if (drawer.Tens < Convert.ToInt32(tbTensDue.Text))
                {
                    enoughChange = false;
                }
                else drawer.Tens -= Convert.ToInt32(tbTensDue.Text);
            }
            if (Convert.ToInt32(tbFivesDue.Text) > 0)
            {
                if (drawer.Fives < Convert.ToInt32(tbFivesDue.Text))
                {
                    enoughChange = false;
                }
                else drawer.Fives -= Convert.ToInt32(tbFivesDue.Text);
            }
            if (Convert.ToInt32(tbTwosDue.Text) > 0)
            {
                if (drawer.Twos < Convert.ToInt32(tbTwosDue.Text))
                {
                    enoughChange = false;
                }
                else drawer.Twos -= Convert.ToInt32(tbTwosDue.Text);
            }
            if (Convert.ToInt32(tbOnesDue.Text) > 0)
            {
                if (drawer.Ones < Convert.ToInt32(tbOnesDue.Text))
                {
                    enoughChange = false;
                }
                else drawer.Ones -= Convert.ToInt32(tbOnesDue.Text);
            }

            if (Convert.ToInt32(tbDollarCoinsDue.Text) > 0)
            {
                if (drawer.Dollars < Convert.ToInt32(tbDollarCoinsDue.Text))
                {
                    enoughChange = false;
                }
                else drawer.Dollars -= Convert.ToInt32(tbDollarCoinsDue.Text);
            }
            if (Convert.ToInt32(tbHalfDollarsDue.Text) > 0)
            {
                if (drawer.HalfDollars < Convert.ToInt32(tbHalfDollarsDue.Text))
                {
                    enoughChange = false;
                }
                else drawer.HalfDollars -= Convert.ToInt32(tbHalfDollarsDue.Text);
            }
            if (Convert.ToInt32(tbQuartersDue.Text) > 0)
            {
                if (drawer.Quarters < Convert.ToInt32(tbQuartersDue.Text))
                {
                    enoughChange = false;
                }
                else drawer.Quarters -= Convert.ToInt32(tbQuartersDue.Text);
            }
            if (Convert.ToInt32(tbDimesDue.Text) > 0)
            {
                if (drawer.Dimes < Convert.ToInt32(tbDimesDue.Text))
                {
                    enoughChange = false;
                }
                else drawer.Dimes -= Convert.ToInt32(tbOnesDue.Text);
            }
            if (Convert.ToInt32(tbNickelsDue.Text) > 0)
            {
                if (drawer.Nickels < Convert.ToInt32(tbNickelsDue.Text))
                {
                    enoughChange = false;
                }
                else drawer.Nickels -= Convert.ToInt32(tbNickelsDue.Text);
            }
            if (Convert.ToInt32(tbPenniesDue.Text) > 0)
            {
                if (drawer.Pennies < Convert.ToInt32(tbPenniesDue.Text))
                {
                    enoughChange = false;
                }
                else drawer.Pennies -= Convert.ToInt32(tbPenniesDue.Text);
            }
            
            //Display a message if there is not enough of a particular amount of change
            if (!enoughChange)
            {
                tbNotEnoughChange.Text = "Need More Change";
                tbNotEnoughChange2.Text = "For Proper Change";
            }

            //Hide the DispenseChangeButton
            DispenseChangeButton.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Click event for the BeginNewOrderButton
        /// </summary>
        /// <param name="sender">The button selected</param>
        /// <param name="e">Routed Event Args</param>
        private void BeginNewOrderButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            PrintCashTransactionReceipt(orderControl);
            orderControl.DataContext = new Order();
            orderControl.ItemSelectionButton.Visibility = Visibility.Visible;
            orderControl.CancelOrderButton.Visibility = Visibility.Visible;
            orderControl.CompleteOrderButton.Visibility = Visibility.Visible;
            orderControl.SummaryBorder.Child = new OrderSummaryControl();
            orderControl.Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// Helper method for printing the receipt from the cash transaction
        /// </summary>
        /// <param name="orderControl"></param>
        private void PrintCashTransactionReceipt(OrderControl orderControl)
        {
            StringBuilder receiptInfo = new StringBuilder();

            //Get the Order information from OrderControl
            var order = orderControl.DataContext as Order;

            //Get the OrderNumber from the Order
            receiptInfo.Append("Order Number: " + order.OrderNumber.ToString() + "\n");

            //Get the current date and time for the receipt
            receiptInfo.Append("Order Taken On: " + DateTime.Now.ToString() + "\n\n");

            //Get the individual order items with price and the special instructions of the items (if any)
            receiptInfo.Append("Order Items:\n");
            foreach (IOrderItem item in order.Items)
            {
                receiptInfo.Append(item.GetType().Name.ToString() + "\t" + string.Format("{0:C}", item.Price) + "\n");
                if (item.SpecialInstructions.Count > 0)
                {
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

            //Get the amount of cash payed by the user and the amount of change they were given
            receiptInfo.Append("Amount of Cash Paid:\t" + tbAmountPayed.Text + "\n"
                + "Amount of Change Given:\t" + tbChangeDue.Text + "\n\n\n");

            //Print the receipt
            ReceiptPrinter printer = new ReceiptPrinter();
            printer.Print(receiptInfo.ToString());
        }
    }
}
  