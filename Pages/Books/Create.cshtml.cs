using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using incerc.Data;
using incerc.Models;

namespace incerc.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly incerc.Data.incercContext _context;

        public CreateModel(incerc.Data.incercContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID",
"PublisherName");
            ViewData["GenreID"] = new SelectList(_context.Set<Genre>(), "ID",
"GenreName");
            ViewData["ShopID"] = new SelectList(_context.Set<Shop>(), "ID",
"ShopName");

            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
