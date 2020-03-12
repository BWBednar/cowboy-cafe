/*
 * Water.cs
 * Author: Brandon Bednar
 * Purpose: A class representing the water drink
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the water drink
    /// </summary>
    public class Water : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event for when values of the item are changed
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the water
        /// </summary>
        public override double Price
        {
            get
            {
                double price;
                switch (Size)
                {
                    case Size.Small:
                        price = 0.12;
                        return price;
                    case Size.Medium:
                        return 0.12;
                    case Size.Large:
                        return 0.12;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories of the water
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        private bool lemon = false;
        /// <summary>
        /// If the water has lemon, default is false
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
            }
        }

        /// <summary>
        /// Special Instructions for the preparation of the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                if (lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

        /// <summary>
        /// Modified ToString for the Point of Sale
        /// </summary>
        /// <returns>The modified string for the Point of Sale</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Water";
                case Size.Medium:
                    return "Medium Water";
                case Size.Large:
                    return "Large Water";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
