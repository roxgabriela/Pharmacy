using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PharmacyStorage.Data;
using PharmacyStorage.Models;

namespace PharmacyStorage.Pages.Prescriptions
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
            ViewData["MedicineID"] = new SelectList(_context.Set<Medicine>(), "ID", "Name");
            ViewData["ClientID"] = new SelectList(_context.Set<Client>(), "ID", "ClientName");
            ViewData["DoctorID"] = new SelectList(_context.Set<Doctor>(), "ID", "DoctorName");
            return Page();
        }

        [BindProperty]
        public Prescription Prescription { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Prescription.Add(Prescription);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
