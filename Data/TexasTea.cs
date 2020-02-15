/*
 * TexasTea.cs
 * Author: Brandon Bednar
 * Purpose: A class representing the Texas Tea drink
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea drink
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// The price of the tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories of the tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        if (sweetTea) return 10;
                        else return 5;
                    case Size.Medium:
                        if (sweetTea) return 22;
                        else return 11;
                    case Size.Large:
                        if (sweetTea) return 36;
                        else return 18;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private bool sweetTea = true;
        /// <summary>
        /// If the tea is sweet or not, default is true
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweetTea;
            }
            set
            {
                sweetTea = value;
            }
        }

        private bool lemon = false;
        /// <summary>
        /// If the tea has lemon, default is false
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
        /// Special Instructions for the preparation of the tea
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
