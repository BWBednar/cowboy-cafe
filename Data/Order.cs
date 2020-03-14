﻿using System;
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
                lastOrderNumber++;
                uint orderNumberValue = lastOrderNumber;
                return orderNumberValue;
            }
        }

        /// <summary>
        /// Adds an IOrderItem to the items list for Order
        /// </summary>
        /// <param name="item">The IOrderItem being added</param>
        public void Add(IOrderItem item)
        {
            //items.Add(item);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            //if (item is INotifyPropertyChanged notifier)
            //{

            //notifier.PropertyChanged += OnItemPropertyChanged;
            //}
            //items.Add(item);
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ToString"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

           
        }

        /// <summary>
        /// Removes an IOrderItem from the items list for Order
        /// </summary>
        /// <param name="item">The IOrderItem being removed</param>
        public void Remove(IOrderItem item)
        {
            //if (item is INotifyPropertyChanged notifier)
            //{
                //notifier.PropertyChanged -= OnItemPropertyChanged;
            //}
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            
            
            if (sender is Drink || sender is Side)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ToString"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }

            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

            //}
        }
    }
}
