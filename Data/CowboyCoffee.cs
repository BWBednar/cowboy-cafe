/*
 * CowboyCoffee.cs
 * Author: Brandon Bednar
 * Purpose: A class representing the Cowboy Coffee drink
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// The price of the coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories of the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private bool coffeeIce = false;
        /// <summary>
        /// If the coffee has ice, default is false
        /// </summary>
        public override bool Ice
        {
            get
            {
                return coffeeIce;
            }
            set
            {
                coffeeIce = value;
                NotifyOfSpecialInstructionsPropertyChange("Ice");
            }
        }

        private bool decaf = false;
        /// <summary>
        /// If the coffee is decaf or not
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
                NotifyOfSpecialInstructionsPropertyChange("Decaf");
                NotifyOfPropertyChange("Items");
                NotifyOfPropertyChange("ToString");
            }
        }

        private bool roomForCream = false;
        /// <summary>
        /// If the coffee has room for cream or not
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
                NotifyOfSpecialInstructionsPropertyChange("RoomForCream");
            }
        }

        /// <summary>
        /// Special Instructions for the preparation of the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add Ice");
                if (roomForCream) instructions.Add("Room for Cream");

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
                    if (decaf) return "Small Decaf Cowboy Coffee";
                    else return "Small Cowboy Coffee";
                case Size.Medium:
                    if (decaf) return "Medium Decaf Cowboy Coffee";
                    else return "Medium Cowboy Coffee";
                case Size.Large:
                    if (decaf) return "Large Decaf Cowboy Coffee";
                    else return "Large Cowboy Coffee";
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Property for the website project to get the simple version of the item name
        /// </summary>
        /// <returns>Item name without size</returns>
        public override string SimpleName { get { return "Cowboy Coffee"; } }
    }
}
