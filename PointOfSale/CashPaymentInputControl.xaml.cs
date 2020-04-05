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
    /// Interaction logic for CashPaymentInputControl.xaml
    /// </summary>
    public partial class CashPaymentInputControl : UserControl
    {
        public CashPaymentInputControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method that gets the amount of money entered by the user and how many of each denomination
        /// </summary>
        /// <param name="coins">The quantity of each coin entered for payment</param>
        /// <param name="bills">The quantity of each bill entered for payment</param>
        /// <returns>The currency value of the money entered by the user</returns>
        public double GetCashAmountEnteredForTransactionControl(out int[] coins, out int[] bills)
        {
            double totalEntered = 0;
            coins = new int[6];
            bills = new int[7];
            //Get the currency value of the coins entered and the quantities
            totalEntered += PennyControl.Quantity * 0.01;
            coins[0] = PennyControl.Quantity;
            totalEntered += NickelControl.Quantity * 0.05;
            coins[1] = NickelControl.Quantity;
            totalEntered += DimeControl.Quantity * 0.10;
            coins[2] = DimeControl.Quantity;
            totalEntered += QuarterControl.Quantity * 0.25;
            coins[3] = QuarterControl.Quantity;
            totalEntered += HalfDollarControl.Quantity * 0.50;
            coins[4] = HalfDollarControl.Quantity;
            totalEntered += DollarControl.Quantity * 1.00;
            coins[5] = DollarControl.Quantity;

            //Get the currency value of the bills entered and the quantites
            totalEntered += OneControl.Quantity * 1.00;
            bills[0] = OneControl.Quantity;
            totalEntered += TwoControl.Quantity * 2.00;
            bills[1] = TwoControl.Quantity;
            totalEntered += FiveControl.Quantity * 5.00;
            bills[2] = FiveControl.Quantity;
            totalEntered += TenControl.Quantity * 10.00;
            bills[3] = TenControl.Quantity;
            totalEntered += TwentyControl.Quantity * 20.00;
            bills[4] = TwentyControl.Quantity;
            totalEntered += FiftyControl.Quantity * 50.00;
            bills[5] = FiftyControl.Quantity;
            totalEntered += HundredControl.Quantity * 100.00;
            bills[6] = HundredControl.Quantity;

            //Return the currency value of the money entered
            return totalEntered;  
        }

        public void EditAmountEnteredTotal()
        {
            double totalEntered = 0;
            //Get the currency value of the coins entered and the quantities
            totalEntered += PennyControl.Quantity * 0.01;
            totalEntered += NickelControl.Quantity * 0.05;
            totalEntered += DimeControl.Quantity * 0.10;
            totalEntered += QuarterControl.Quantity * 0.25;
            totalEntered += HalfDollarControl.Quantity * 0.50;
            totalEntered += DollarControl.Quantity * 1.00;

            //Get the currency value of the bills entered and the quantites
            totalEntered += OneControl.Quantity * 1.00;
            totalEntered += TwoControl.Quantity * 2.00;
            totalEntered += FiveControl.Quantity * 5.00;
            totalEntered += TenControl.Quantity * 10.00;
            totalEntered += TwentyControl.Quantity * 20.00;
            totalEntered += FiftyControl.Quantity * 50.00;
            totalEntered += HundredControl.Quantity * 100.00;

            //Set the AmountPayed text box
            tbAmountPayed.Text = string.Format("{0:C}", totalEntered);

            //Set the AmountRemaining text box
            double amountRemaining = this.FindAncestor<OrderControl>().GetTotalDueFromOrderControl();
            amountRemaining -= totalEntered;
            //Set the AmountRemaining is no more money is owed
            if (amountRemaining < 0) amountRemaining = 0;
            tbAmountRemaining.Text = string.Format("{0:C}", amountRemaining);
        }
    }
}
