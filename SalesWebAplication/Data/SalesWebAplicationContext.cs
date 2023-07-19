using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebAplication.Models;

namespace SalesWebAplication.Data
{
    public class SalesWebAplicationContext : DbContext
    {
        public SalesWebAplicationContext (DbContextOptions<SalesWebAplicationContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebAplication.Models.Department> Department { get; set; } = default!;
    }
}
