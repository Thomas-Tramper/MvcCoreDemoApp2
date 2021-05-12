using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcCoreDemoApp2.Models;

namespace MvcCoreDemoApp2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MvcCoreDemoApp2.Models.SupplierModel> SupplierModel { get; set; }
        public DbSet<MvcCoreDemoApp2.Models.ProductsModel> ProductsModel { get; set; }
    }
}
