﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PharmacyStorage.Data;
using PharmacyStorage.Models;

namespace PharmacyStorage.Pages.Providers
{
    public class CreateModel : PageModel
    {
        private readonly PharmacyStorage.Data.PharmacyStorageContext _context;

        public CreateModel(PharmacyStorage.Data.PharmacyStorageContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Provider Provider { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Provider.Add(Provider);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
