using HW27122021.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW27122021.Infrastructure.DataContext
{
    public class DbContextHW:DbContext
    {
        public DbContextHW(DbContextOptions<DbContextHW> options):base (options)
        {

        }
        public virtual DbSet<Inventario> _inventario { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
