/*
 * Menu.cs
 * Author: Brandon Bednar
 * Purpose: A static class for retrieving lists of menu items
 */

using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A static class for retrieving lists of menu items
    /// </summary>
    public static class Menu 
    {
        public static string[] ItemTypes
        {
            get => new string[]
            {
                "Entrees",
                "Sides",
                "Drinks"
            };
        }



        /// <summary>
        /// IEnumberable to get the list of entrees
        /// </summary>
        public static IEnumerable<IOrderItem> Entrees
        {
            get
            {
                List<IOrderItem> entrees = new List<IOrderItem>();
                entrees.Add(new AngryChicken());
                entrees.Add(new CowpokeChili());
                entrees.Add(new DakotaDoubleBurger());
                entrees.Add(new PecosPulledPork());
                entrees.Add(new RustlersRibs());
                entrees.Add(new TexasTripleBurger());
                entrees.Add(new TrailBurger());
                return (IEnumerable<IOrderItem>)entrees;
            }
        }

        /// <summary>
        /// IEnumberable to get the list of sides
        /// </summary>
        public static IEnumerable<IOrderItem> Sides
        {
            get
            {
                List<IOrderItem> sides = new List<IOrderItem>();
                foreach(Size size in Enum.GetValues(typeof(Size)))
                {
                    var item = new BakedBeans();
                    item.Size = size;
                    sides.Add(item);
                }
                foreach (Size size in Enum.GetValues(typeof(Size)))
                {
                    var item = new ChiliCheeseFries();
                    item.Size = size;
                    sides.Add(item);
                }
                foreach (Size size in Enum.GetValues(typeof(Size)))
                {
                    var item = new CornDodgers();
                    item.Size = size;
                    sides.Add(item);
                }
                foreach (Size size in Enum.GetValues(typeof(Size)))
                {
                    var item = new PanDeCampo();
                    item.Size = size;
                    sides.Add(item);
                }
                return (IEnumerable<IOrderItem>)sides;
            }
        }

        /// <summary>
        /// IEnumberable to get the list of drinks
        /// </summary>
        public static IEnumerable<IOrderItem> Drinks
        {
            get
            {
                List<IOrderItem> drinks = new List<IOrderItem>();
                foreach (Size size in Enum.GetValues(typeof(Size)))
                {
                    var item = new CowboyCoffee();
                    item.Size = size;
                    drinks.Add(item);
                }
                foreach (Size size in Enum.GetValues(typeof(Size)))
                {
                    var item = new JerkedSoda();
                    item.Size = size;
                    drinks.Add(item);
                }
                foreach (Size size in Enum.GetValues(typeof(Size)))
                {
                    var item = new TexasTea();
                    item.Size = size;
                    drinks.Add(item);
                }
                foreach (Size size in Enum.GetValues(typeof(Size)))
                {
                    var item = new TexasTea();
                    item.Sweet = false;
                    item.Size = size;
                    drinks.Add(item);
                }
                foreach (Size size in Enum.GetValues(typeof(Size)))
                {
                    var item = new Water();
                    item.Size = size;
                    drinks.Add(item);
                }
                return (IEnumerable<IOrderItem>)drinks;
            }
        }

        /// <summary>
        /// IEnumberable to get the list of all items
        /// </summary>
        public static IEnumerable<IOrderItem> CompleteMenu
        {
            get
            {
                List<IOrderItem> completeMenu = new List<IOrderItem>();
                foreach (IOrderItem entree in Entrees) completeMenu.Add(entree);
                foreach (IOrderItem side in Sides) completeMenu.Add(side);
                foreach (IOrderItem drink in Drinks) completeMenu.Add(drink);
                return (IEnumerable<IOrderItem>)completeMenu;
            }
        }
    }
}
