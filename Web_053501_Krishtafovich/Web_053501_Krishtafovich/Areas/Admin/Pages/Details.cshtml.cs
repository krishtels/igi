using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_053501_Krishtafovich.Data;
using Web_053501_Krishtafovich.Entities;

namespace Web_053501_Krishtafovich.Areas.Admin.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Web_053501_Krishtafovich.Data.ApplicationDbContext _context;

        public DetailsModel(Web_053501_Krishtafovich.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Dish Dish { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Dishes == null)
            {
                return NotFound();
            }

            var dish = await _context.Dishes.FirstOrDefaultAsync(m => m.DishId == id);
            if (dish == null)
            {
                return NotFound();
            }
            else 
            {
                Dish = dish;
            }
            return Page();
        }
    }
}
