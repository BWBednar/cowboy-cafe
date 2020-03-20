/*
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
    public class AngryChicken : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event for when values of the item are changed
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        private bool bread = true;
        /// <summary>
        /// If the chicken includes bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { 
                bread = value;
                NotifyOfSpecialInstructionsPropertyChange("Cheese");
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

        /// <summary>
        /// Helper method for changing the special instructions of the item
        /// </summary>
        /// <param name="propertyName">The name of the property being changed</param>
        protected void NotifyOfSpecialInstructionsPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
