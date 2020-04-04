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

        public double GetCashAmountEntered()
        {
            double totalEntered = 0;
            //Get the currency value of the coins entered
            totalEntered += PennyControl.Quantity * 0.01;
            totalEntered += NickelControl.Quantity * 0.05;
            totalEntered += DimeControl.Quantity * 0.10;
            totalEntered += QuarterControl.Quantity * 0.25;
            totalEntered += HalfDollarControl.Quantity * 0.50;
            totalEntered += DollarControl.Quantity * 1.00;

            //Get the currency value of the bills entered
            totalEntered += OneControl.Quantity * 1.00;
            totalEntered += TwoControl.Quantity * 2.00;
            totalEntered += FiveControl.Quantity * 5.00;
            totalEntered += TenControl.Quantity * 10.00;
            totalEntered += TwentyControl.Quantity * 20.00;
            totalEntered += FiftyControl.Quantity * 50.00;
            totalEntered += HundredControl.Quantity * 100.00;
            return totalEntered;
            
        }
    }
}
