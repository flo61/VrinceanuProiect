﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using incerc.Data;
using incerc.Models;

namespace incerc.Pages.Shops
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
            return Page();
        }

        [BindProperty]
        public Shop Shop { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Shop.Add(Shop);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
