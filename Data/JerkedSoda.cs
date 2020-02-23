/*
 * JerkedSoda.cs
 * Author: Brandon Bednar
 * Purpose: A class representing the Jerked Soda drink
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Jerked Soda drink
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// The flavor of the soda
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// The price of the soda
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
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Special Instructions for the preparation of the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// Modified ToString for the Point of Sale
        /// </summary>
        /// <returns>The modified string for the Point of Sale</returns>
        public override string ToString()
        {
            StringBuilder printOut = new StringBuilder();
            switch (Size)
            {
                case Size.Small:
                    printOut.Append("Small ");
                    break;
                case Size.Medium:
                    printOut.Append("Medium ");
                    break;
                case Size.Large:
                    printOut.Append("Large ");
                    break;
                default:
                    throw new NotImplementedException();
            }
            switch (Flavor)
            {
                case SodaFlavor.CreamSoda:
                    printOut.Append("Cream Soda ");
                    break;
                case SodaFlavor.OrangeSoda:
                    printOut.Append("Orange Soda ");
                    break;
                case SodaFlavor.Sarsparilla:
                    printOut.Append("Sarsparilla ");
                    break;
                case SodaFlavor.BirchBeer:
                    printOut.Append("Birch Beer ");
                    break;
                case SodaFlavor.RootBeer:
                    printOut.Append("Root Beer ");
                    break;
                default:
                    throw new NotImplementedException();
            }
            printOut.Append("Jerked Soda");
            return printOut.ToString();
        }
    }
}
