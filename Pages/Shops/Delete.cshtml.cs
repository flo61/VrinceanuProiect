using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using incerc.Data;
using incerc.Models;

namespace incerc.Pages.Shops
{
    public class DeleteModel : PageModel
    {
        private readonly incerc.Data.incercContext _context;

        public DeleteModel(incerc.Data.incercContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Shop Shop { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Shop == null)
            {
                return NotFound();
            }

            var shop = await _context.Shop.FirstOrDefaultAsync(m => m.ID == id);

            if (shop == null)
            {
                return NotFound();
            }
            else 
            {
                Shop = shop;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Shop == null)
            {
                return NotFound();
            }
            var shop = await _context.Shop.FindAsync(id);

            if (shop != null)
            {
                Shop = shop;
                _context.Shop.Remove(Shop);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
