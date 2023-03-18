using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesW.Models;

namespace SalesW.Data
{
    public class SalesWContext : DbContext
    {
        public SalesWContext (DbContextOptions<SalesWContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecords { get; set; }
        public DbSet<Seller> Seller { get; set; }
    }
}
