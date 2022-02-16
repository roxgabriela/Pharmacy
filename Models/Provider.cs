using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyStorage.Models
{
    public class Provider
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Medicine> Medication { get; set; }
        public string FactoryAddress { get; set; }

    }
}
