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
    public class IndexModel : PageModel
    {
        private readonly Web_053501_Krishtafovich.Data.ApplicationDbContext _context;

        public IndexModel(Web_053501_Krishtafovich.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Dish> Dish { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Dishes != null)
            {
                Dish = await _context.Dishes
                .Include(d => d.Group).ToListAsync();
            }
        }
    }
}
