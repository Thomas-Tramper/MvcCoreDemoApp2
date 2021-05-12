using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreDemoApp2.Models
{
    public class SupplierModel
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string SupplierName { get; set; }


    }
}
