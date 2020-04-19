/*
 * CornDodgers.cs
 * Author: Brandon Bednar
 * Purpose: A class representing the Corn Dodgers side
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Corn Dodgers side
    /// </summary>
    public class CornDodgers : Side, IOrderItem
    {
        /// <summary>
        /// Empty special instructions to satisfy IOrderItem requirements
        /// </summary>
        public List<string> SpecialInstructions => new List<string>();

        /// <summary>
        /// The calories of the corn dodgers depending on the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The price of the corn dodgers depending on the size
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
                    return "Small Corn Dodgers";
                case Size.Medium:
                    return "Medium Corn Dodgers";
                case Size.Large:
                    return "Large Corn Dodgers";
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Property for the website project to get the simple version of the item name
        /// </summary>
        /// <returns>Item name without size</returns>
        public override string SimpleName { get { return "Corn Dodgers"; } }
    }
}
