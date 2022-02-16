using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyStorage.Models
{
    public class Prescription
    {
        public int ID { get; set; }
        public string Diagnosis { get; set; }
        public int MedicineID { get; set; }
        public Medicine Medicine { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
    }
}
