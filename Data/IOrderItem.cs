/*
 * IOrderItem.cs
 * Author: Brandon Bednar
 * Purpose: A interface that helps communicate order information to PointOfSale
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price fot this order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The special instructions for this order item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
