using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork
    {
        /*
         * Implement a class to represent the Pecos Pulled Pork entree. Its price is $5.88 
         * and its calories are 528. It should have boolean properties for Bread and Pickle
         * , which default to true. When Bread is false, the special instructions include th
         * e string “hold bread” and when Pickle is false, the special instructions should include the string “hold pickle”.
         */

        private bool bread = true;
        /// <summary>
        /// If the pulled pork has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If the pulled pork has a pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// The price of the pulled pork
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the pulled pork
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the pulled pork
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");
            }
        }
    }
}
