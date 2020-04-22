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

        public void OnGet(int? MinCalories, int? MaxCalories, double? MinPrice, double? MaxPrice)
        {
            this.MinCalories = MinCalories;
            this.MaxCalories = MaxCalories;
            this.MinPrice = MinPrice;
            this.MaxPrice = MaxPrice;
            SearchTerms = Request.Query["SearchTerms"];
            ItemTypes = Request.Query["ItemTypes"];
            items = Menu.Search(SearchTerms);
            items = Menu.FilterByCategory(Items, ItemTypes);
            items = Menu.FilterByCalories(Items, MinCalories, MaxCalories);
            items = Menu.FilterByPrice(Items, MinPrice, MaxPrice); 
        }

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
