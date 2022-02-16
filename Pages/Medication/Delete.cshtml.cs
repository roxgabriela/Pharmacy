using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PharmacyStorage.Data;
using PharmacyStorage.Models;

namespace PharmacyStorage.Pages.Medications
{
    public class DeleteModel : PageModel
    {
        private readonly PharmacyStorage.Data.PharmacyStorageContext _context;

        public DeleteModel(PharmacyStorage.Data.PharmacyStorageContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Medicine Medicine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medicine = await _context.Medicine.FirstOrDefaultAsync(m => m.ID == id);

            if (Medicine == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medicine = await _context.Medicine.FindAsync(id);

            if (Medicine != null)
            {
                _context.Medicine.Remove(Medicine);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
