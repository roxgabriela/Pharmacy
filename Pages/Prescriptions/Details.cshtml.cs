using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PharmacyStorage.Data;
using PharmacyStorage.Models;

namespace PharmacyStorage.Pages.Prescriptions
{
    public class DetailsModel : PageModel
    {
        private readonly PharmacyStorage.Data.PharmacyStorageContext _context;

        public DetailsModel(PharmacyStorage.Data.PharmacyStorageContext context)
        {
            _context = context;
        }

        public Prescription Prescription { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Prescription = await _context.Prescription.FirstOrDefaultAsync(m => m.ID == id);

            if (Prescription == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
