/*
 * PanDeCampo.cs
 * Author: Brandon Bednar
 * Purpose: A class representing the Pan De Campo side
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pan De Campo side
    /// </summary>
    public class PanDeCampo : Side, IOrderItem
    {
        /// <summary>
        /// Empty special instructions to satisfy IOrderItem requirements
        /// </summary>
        public List<string> SpecialInstructions => new List<string>();

        /// <summary>
        /// The calories of the pan de campo depending on the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The price of the pan de campo depending on the size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
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
                    return "Small Pan de Campo";
                case Size.Medium:
                    return "Medium Pan de Campo";
                case Size.Large:
                    return "Large Pan de Campo";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
