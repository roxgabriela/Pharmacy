using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PharmacyStorage.Models;

namespace PharmacyStorage.Data
{
    public class PharmacyStorageContext : DbContext
    {
        public PharmacyStorageContext (DbContextOptions<PharmacyStorageContext> options)
            : base(options)
        {
        }

        public DbSet<PharmacyStorage.Models.Medicine> Medicine { get; set; }

        public DbSet<PharmacyStorage.Models.Provider> Provider { get; set; }

        public DbSet<PharmacyStorage.Models.Client> Client { get; set; }

        public DbSet<PharmacyStorage.Models.Doctor> Doctor { get; set; }

        public DbSet<PharmacyStorage.Models.Prescription> Prescription { get; set; }
    }
}
