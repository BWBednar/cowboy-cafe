/*
 * Water.cs
 * Author: Brandon Bednar
 * Purpose: A class representing the water drink
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the water drink
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// The price of the water
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.12;
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
    }
}
