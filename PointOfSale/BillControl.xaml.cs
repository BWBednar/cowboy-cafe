﻿/*
 * BillControl.xaml.cs
 * Author: Nathan Bean
 * Editted by: Brandon Bednar
 * Purpose: Backing code for the BillControl control
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
using CashRegister;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for BillControl.xaml
    /// </summary>
    public partial class BillControl : UserControl
    {
        /// <summary>
        /// Initialize BillControl
        /// </summary>
        public BillControl()
        {
            InitializeComponent();
        }

        // Using a DependencyProperty as the backing store for the Denomination Property.  
        //This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DenominationProperty =
        DependencyProperty.Register(
            "Denomination",                     // The name of the property
            typeof(Bills),                      // The type of the property
            typeof(BillControl),                // The property's control
            new PropertyMetadata(Bills.One)   // The Property Medata
            );

        /// <summary>
        /// The denomination of the bill
        /// </summary>
        public Bills Denomination
        {
            get { return (Bills)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }


        /// <summary>
        /// The DependencyProperty backing the Quantity property
        /// </summary>
        public static readonly DependencyProperty QuantityProperty =
                DependencyProperty.Register(
                    "Quantity",
                    typeof(int),
                    typeof(BillControl),
                    new FrameworkPropertyMetadata(
                        0,
                        FrameworkPropertyMetadataOptions.BindsTwoWayByDefault
                    )
                );

        /// <summary>
        /// The quantity of the bill denomination
        /// </summary>
        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }

        /// <summary>
        /// Increases the quantity of the bound bill by one
        /// </summary>
        /// <param name="sender">The bill quanity (as an int)</param>
        /// <param name="args">The event args</param>
        public void OnIncreaseClicked(object sender, RoutedEventArgs args)
        {
            Quantity++;
            var cashInputControl = this.FindAncestor<CashPaymentInputControl>();
            cashInputControl.EditAmountEnteredTotal();
        }

        /// <summary>
        /// Decreases the quantity of the bound bill by one
        /// </summary>
        /// <param name="sender">The bill quantity (as in int)</param>
        /// <param name="args">The event args</param>
        public void OnDecreaseClicked(object sender, RoutedEventArgs args)
        {
            int quantity = Quantity;
            if (quantity-- > 0) Quantity--;
            var cashInputControl = this.FindAncestor<CashPaymentInputControl>();
            cashInputControl.EditAmountEnteredTotal();
        }
    }
}