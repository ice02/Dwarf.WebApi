using Dwarf.Database.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dwarf.Database
{
    public class DwarfContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DwarfContext() : base()
        {
        }

        public DwarfContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
}
