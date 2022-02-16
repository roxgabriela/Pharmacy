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
    public class IndexModel : PageModel
    {
        private readonly PharmacyStorage.Data.PharmacyStorageContext _context;

        public IndexModel(PharmacyStorage.Data.PharmacyStorageContext context)
        {
            _context = context;
        }

        public IList<Medicine> Medicine { get;set; }

        public async Task OnGetAsync()
        {
            Medicine = await _context.Medicine.Include(m => m.Provider).ToListAsync();
        }
    }
}
