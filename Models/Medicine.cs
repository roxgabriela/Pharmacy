using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PharmacyStorage.Models
{
    public class Medicine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }
        public int ProviderID { get; set; }
        public Provider Provider { get; set; }


    }
}
