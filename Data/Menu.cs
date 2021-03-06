﻿/*
 * Menu.cs
 * Author: Brandon Bednar
 * Purpose: A static class for retrieving lists of menu items and for searching the items for specific details
 */

using System;
using System.Collections.Generic;
using System.Linq;
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
        /// String array property that contains all Item Base Types
        /// </summary>
        public static string[] ItemTypes
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }

        /// <summary>
        /// String array property that contains all Jerked Soda Flavors
        /// Used for information display, not searching
        /// </summary>
        public static string[] JerkedSodaFlavors
        {
            get => new string[]
            {
                "Cream Soda",
                "Orange Soda",
                "Sarsparilla",
                "Birch Beer",
                "Root Beer"
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
        
        /// <summary>
        /// Method that returns an IEnumerable of all items from CompleteMenu that contain a specified string
        /// </summary>
        /// <param name="searchTerm">The specified string being search for in the items</param>
        /// <returns>IEnumberable of all items that contain the specified string</returns>
        public static IEnumerable<IOrderItem> Search (string searchTerm)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (searchTerm == null) return CompleteMenu;
            foreach(IOrderItem item in CompleteMenu)
            {
                var test = item.ToString();
                if (item != null && item.ToString().Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;

        }

        /// <summary>
        /// Method that returns an IEnumerable of all items that contain a specified type of item Base Type
        /// </summary>
        /// <param name="items">The IEnumberable of items being searched through</param>
        /// <param name="types">Strings of the Base Types of items being searched for</param>
        /// <returns>An IEnumerable that contains all the itesm from the given list with the specified Base Types</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> types)
        {
            if (types == null || types.Count() == 0) return items;
            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in items)
            {
                if (item.GetType().BaseType.Name != null && types.Contains(item.GetType().BaseType.Name))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Method that returns an IEnumerable of all items that fall within a specified range for the Calories property
        /// </summary>
        /// <param name="items">The IEnumberable of items being searched through</param>
        /// <param name="min">The lower boundary for the calorie range being searched for</param>
        /// <param name="max">The upper boundary for the calorie range being searched for</param>
        /// <returns>An IEnumerable that contains all the items from the given list that fall within the range for the Calories property</returns>
        public static IEnumerable<IOrderItem> FilterByCalories (IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;
            List<IOrderItem> results = new List<IOrderItem>();
            if (min == null)
            {
                foreach(IOrderItem item in items)
                {
                    if(item is Entree entree)
                    {
                        if (entree.Calories <= max) results.Add(item);
                    }
                    else if (item is Side side)
                    {
                        if (side.Calories <= max) results.Add(item);
                    }
                    else if (item is Drink drink)
                    {
                        if (drink.Calories <= max) results.Add(item);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item is Entree entree)
                    {
                        if (entree.Calories >= min) results.Add(item);
                    }
                    else if (item is Side side)
                    {
                        if (side.Calories >= min) results.Add(item);
                    }
                    else if (item is Drink drink)
                    {
                        if (drink.Calories >= min) results.Add(item);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            foreach (IOrderItem item in items)
            {
                if (item is Entree entree)
                {
                    if (entree.Calories >= min && entree.Calories <= max) results.Add(item);
                }
                else if (item is Side side)
                {
                    if (side.Calories >= min && side.Calories <= max) results.Add(item);
                }
                else if (item is Drink drink)
                {
                    if (drink.Calories >= min && drink.Calories <= max) results.Add(item);
                }
                else
                {
                    throw new Exception();
                }
            }

            return results;
        }

        /// <summary>
        /// Method that returns an IEnumerable of all items that fall within a specified range for the Price property
        /// </summary>
        /// <param name="items">The IEnumberable of items being searched through</param>
        /// <param name="min">The lower boundary for the price range being searched for</param>
        /// <param name="max">The upper boundary for the price range being searched for</param>
        /// <returns>An IEnumerable that contains all the items from the given list that fall within the range for the Price property</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            List<IOrderItem> results = new List<IOrderItem>();
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item is Entree entree)
                    {
                        if (entree.Price <= max) results.Add(item);
                    }
                    else if (item is Side side)
                    {
                        if (side.Price <= max) results.Add(item);
                    }
                    else if (item is Drink drink)
                    {
                        if (drink.Price <= max) results.Add(item);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item is Entree entree)
                    {
                        if (entree.Price >= min) results.Add(item);
                    }
                    else if (item is Side side)
                    {
                        if (side.Price >= min) results.Add(item);
                    }
                    else if (item is Drink drink)
                    {
                        if (drink.Price >= min) results.Add(item);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            foreach (IOrderItem item in items)
            {
                if (item is Entree entree)
                {
                    if (entree.Price >= min && entree.Price <= max) results.Add(item);
                }
                else if (item is Side side)
                {
                    if (side.Price >= min && side.Price <= max) results.Add(item);
                }
                else if (item is Drink drink)
                {
                    if (drink.Price >= min && drink.Price <= max) results.Add(item);
                }
                else
                {
                    throw new Exception();
                }
            }

            return results;
        }
        
    }
}
