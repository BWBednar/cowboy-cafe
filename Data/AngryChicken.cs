﻿/*
 * AngryChicken.cs
 * Author: Brandon Bednar
 * Purpose: A class representing the Angry Chicken entree
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken : Entree, INotifyPropertyChanged
    {
        private bool bread = true;
        /// <summary>
        /// If the chicken includes bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { 
                bread = value;
                NotifyOfSpecialInstructionsPropertyChange("Bread");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the chicken includes pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { 
                pickle = value;
                NotifyOfSpecialInstructionsPropertyChange("Pickle");
            }
        }
        /// <summary>
        /// The price of the chicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the chicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// Modified ToString for the Point of Sale
        /// </summary>
        /// <returns>The modified string for the Point of Sale</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
