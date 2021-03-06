﻿/*
 * Order.cs
 * Author: Brandon Bednar
 * Purpose: A class that contains the total order of entree, side, and drink classes
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class for the Order that will be displayed in PointOfSale
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Event for when the values in Order are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The order number, will increment each new Order created
        /// </summary>
        private static uint lastOrderNumber = 0;

        /// <summary>
        /// The list of IOrderItems in the Order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Constructor for the Order, meant only to increment the order number
        /// </summary>
        public Order()
        {
            lastOrderNumber++;
        }

        /// <summary>
        /// The subtotal of the IOrderItems in the Order items
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0.0;
                foreach (IOrderItem part in items)
                {
                    subtotal += part.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// The tax for the Order items based on Subtotal
        /// </summary>
        public double Tax
        {
            get
            {
                return Subtotal * 0.16;
            }
        }

        /// <summary>
        /// The total for the Order items based on Subtotal and Tax
        /// </summary>
        public double Total
        {
            get
            {
                return Subtotal + Tax;
            }
        }
        
        /// <summary>
        /// The public field to access the items in Order
        /// </summary>
        public IEnumerable<IOrderItem> Items { get => items.ToArray(); }
        
        /// <summary>
        /// The order number that will be given with the order, incremented each Order
        /// </summary>
        public uint OrderNumber
        {
            get
            {
                return lastOrderNumber;
            }
        }

        /// <summary>
        /// Adds an IOrderItem to the items list for Order
        /// </summary>
        /// <param name="item">The IOrderItem being added</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
        }

        /// <summary>
        /// Removes an IOrderItem from the items list for Order
        /// </summary>
        /// <param name="item">The IOrderItem being removed</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
        }

        
        /// <summary>
        /// Method for notifying the order of size related changes
        /// </summary>
        public void NotifyItemChange()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
        }
    }
}
