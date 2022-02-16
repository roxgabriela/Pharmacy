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
    public class IndexModel : PageModel
    {
        private readonly PharmacyStorage.Data.PharmacyStorageContext _context;

        public IndexModel(PharmacyStorage.Data.PharmacyStorageContext context)
        {
            _context = context;
        }

        public IList<Prescription> Prescription { get;set; }

        public async Task OnGetAsync()
        {
            Prescription = await _context.Prescription.Include(c => c.Client).Include(d => d.Doctor).Include(m => m.Medicine).ToListAsync();
        }
    }
}
