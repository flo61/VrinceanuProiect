using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using incerc.Data;
using incerc.Models;

namespace incerc.Pages.Genres
{
    public class IndexModel : PageModel
    {
        private readonly incerc.Data.incercContext _context;

        public IndexModel(incerc.Data.incercContext context)
        {
            _context = context;
        }

        public IList<Genre> Genre { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Genre != null)
            {
                Genre = await _context.Genre.ToListAsync();
            }
        }
    }
}
