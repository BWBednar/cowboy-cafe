/*
 * BakedBeans.cs
 * Author: Brandon Bednar
 * Purpose: A class representing the Baked Beans Fries side
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Baked Beans Fries side
    /// </summary>
    public class BakedBeans : Side
    {
        /// <summary>
        /// The calories of the baked beans depending on the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The price of the baked beans depending on the size
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
        /// Empty special instructions to satisfy IOrderItem requirements
        /// </summary>
        public override List<string> SpecialInstructions => new List<string>();

        /// <summary>
        /// Modified ToString for the Point of Sale
        /// </summary>
        /// <returns>The modified string for the Point of Sale</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Baked Beans";
                case Size.Medium:
                    return "Medium Baked Beans";
                case Size.Large:
                    return "Large Baked Beans";
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Property for the website project to get the simple version of the item name
        /// </summary>
        /// <returns>Item name without size</returns>
        public override string SimpleName { get { return "Baked Beans"; } }
    }
}
