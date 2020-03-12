/*
 * Drink.cs
 * Author: Brandon Bednar
 * Purpose: Base class for the drinks
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Base class for the drinks
    /// </summary>
    public abstract class Drink : INotifyPropertyChanged
    {
        /// <summary>
        /// Event for when the values of the drink are changed
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;

        Size size = Size.Small;
        /// <summary>
        /// Size of the drink, initialized to Size.Small
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                value = size;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// The price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        private bool ice = true;
        /// <summary>
        /// If the drink has ice, initialized to true
        /// </summary>
        public virtual bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }

        /// <summary>
        /// The Special Instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions {get;}

        /// <summary>
        /// Helper method to notify if boolean changes have been made
        /// </summary>
        /// <param name="propertyName">The name of the property being changed</param>
        private void NotifyOfSpecialInstructionsPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        
    }
}
