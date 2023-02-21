using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using incerc.Data;
using incerc.Models;

namespace incerc.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly incerc.Data.incercContext _context;

        public IndexModel(incerc.Data.incercContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                    .Include(b => b.Publisher)
                    .Include(b => b.Genre)
                    .Include(b => b.Shop)

.ToListAsync();
            }
        }
    }
}
