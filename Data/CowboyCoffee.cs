/*
 * CowboyCoffee.cs
 * Author: Brandon Bednar
 * Purpose: A class representing the Cowboy Coffee drink
 */

using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
