using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DarpinosPizza.Models;

namespace DarpinosPizza.Data
{
    public class DarpinosPizzaContext : DbContext
    {
        public DarpinosPizzaContext (DbContextOptions<DarpinosPizzaContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<PurchasesRecords> Purchases { get; set; } = default!;
    }
}
