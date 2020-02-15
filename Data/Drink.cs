/*
 * Drink.cs
 * Author: Brandon Bednar
 * Purpose: Base class for the drinks
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Base class for the drinks
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Size of the drink, initialized to Size.Small
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

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
            }
        }

        /// <summary>
        /// The Special Instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions {get;}
    }
}
