using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PharmacyStorage.Data;
using PharmacyStorage.Models;

namespace PharmacyStorage.Pages.Doctors
{
    public class IndexModel : PageModel
    {
        private readonly PharmacyStorage.Data.PharmacyStorageContext _context;

        public IndexModel(PharmacyStorage.Data.PharmacyStorageContext context)
        {
            _context = context;
        }

        public IList<Doctor> Doctor { get;set; }

        public async Task OnGetAsync()
        {
            Doctor = await _context.Doctor.ToListAsync();
        }
    }
}
