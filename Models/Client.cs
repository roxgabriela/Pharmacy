using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyStorage.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string ClientName { get; set; }
        public string CNP { get; set; }
        public string Address { get; set; }
        public Prescription Prescription { get; set; }
    }
}
