﻿/*
 * Index.cshtml.cs
 * Author: Brandon Bednar
 * Purpose: Backing code for the Index.cshtml page for the Website
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Method that updates the information displayed each time the page is called
        /// </summary>
        /// <param name="MinCalories">Minimum calories for the search functionality</param>
        /// <param name="MaxCalories">Maximum calories for the search functionality</param>
        /// <param name="MinPrice">Minimum price for the search functionality</param>
        /// <param name="MaxPrice">Maximum price for the search functionality</param>
        public void OnGet(int? MinCalories, int? MaxCalories, double? MinPrice, double? MaxPrice)
        {
            this.MinCalories = MinCalories;
            this.MaxCalories = MaxCalories;
            this.MinPrice = MinPrice;
            this.MaxPrice = MaxPrice;
            SearchTerms = Request.Query["SearchTerms"];
            ItemTypes = Request.Query["ItemTypes"];
            
            //Search through items by SearchTerms
            if (SearchTerms != null)
            {
                items = Menu.CompleteMenu.Where(item =>
                item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)
                );
            }
            //Search through items by ItemTypes
            if (ItemTypes != null && ItemTypes.Length != 0)
            {
                items = Items.Where(item =>
                item.GetType().BaseType.Name != null &&
                ItemTypes.Contains(item.GetType().BaseType.Name)
                );
            }
            //Search through items by Max and MinCalories
            if (!(MinCalories == null && MaxCalories == null))
            {
                if (MinCalories == null && MaxCalories != null)
                {
                    items = Items.Where(item =>
                    item.Calories <= MaxCalories
                    );
                }
                else if (MinCalories != null && MaxCalories == null)
                {
                    items = Items.Where(item =>
                    item.Calories >= MinCalories
                    );
                }
                else
                {
                    items = Items.Where(item =>
                    item.Calories >= MinCalories &&
                    item.Calories <= MaxCalories
                    );
                }
            }
            //Search through items by Min and MaxPrice
            if (!(MinPrice == null && MaxPrice == null))
            {
                if (MinPrice == null && MaxPrice != null)
                {
                    items = Items.Where(item =>
                    item.Price <= MaxPrice
                    );
                }
                else if (MinPrice != null && MaxPrice == null)
                {
                    items = Items.Where(item =>
                    item.Price >= MinPrice
                    );
                }
                else
                {
                    items = Items.Where(item =>
                    item.Price >= MinPrice &&
                    item.Price <= MaxPrice
                    );
                }
            }
        }

        /// <summary>
        /// Backing variable for the items displayed
        /// </summary>
        private IEnumerable<IOrderItem> items = Menu.CompleteMenu;
        /// <summary>
        /// The menu items to display on the index page
        /// </summary>
        public IEnumerable<IOrderItem> Items 
        { 
            get 
            {
                return items;
            } 
            private set { } 
        }

        /// <summary>
        /// The string being searched for
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// The type of item being search for (entree, side, drink)
        /// </summary>
        [BindProperty]
        public string[] ItemTypes { get; set; }

        /// <summary>
        /// The minimum amount of calories being searched for
        /// </summary>
        public int? MinCalories { get; set; }

        /// <summary>
        /// The maximum amount of calories being searched for
        /// </summary>
        public int? MaxCalories { get; set; }

        /// <summary>
        /// The minimum price being searched for
        /// </summary>
        public double? MinPrice { get; set; }

        /// <summary>
        /// The maximum price being searched for
        /// </summary>
        public double? MaxPrice { get; set; }

    }
}
