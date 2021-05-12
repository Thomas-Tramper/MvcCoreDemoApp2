using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreDemoApp2.Models
{
    public class ProductsModel
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string productName { get; set; }

        public int supplierID { get; set; }

        public virtual SupplierModel supplier { get; set; }
    }
}
