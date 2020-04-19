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
        /// <summary>
        /// IEnumberable to get the list of entrees
        /// </summary>
        public static IEnumerable<IOrderItem> Entrees() 
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

        /// <summary>
        /// IEnumberable to get the list of sides
        /// </summary>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(new BakedBeans());
            sides.Add(new ChiliCheeseFries());
            sides.Add(new CornDodgers());
            sides.Add(new PanDeCampo());
            return (IEnumerable<IOrderItem>)sides;
        }

        /// <summary>
        /// IEnumberable to get the list of drinks
        /// </summary>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks.Add(new CowboyCoffee());
            drinks.Add(new JerkedSoda());
            drinks.Add(new TexasTea());
            drinks.Add(new Water());
            return (IEnumerable<IOrderItem>)drinks;
        }

        /// <summary>
        /// IEnumberable to get the list of all items
        /// </summary>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> completeMenu = new List<IOrderItem>();
            foreach(IOrderItem entree in Entrees()) completeMenu.Add(entree);
            foreach (IOrderItem side in Sides()) completeMenu.Add(side);
            foreach (IOrderItem drink in Drinks()) completeMenu.Add(drink);
            return (IEnumerable<IOrderItem>)completeMenu;
        } 
    }
}
