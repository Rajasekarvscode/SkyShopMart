using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
using Microsoft.Extensions.Options;
using Infrastructure.Config;
namespace Infrastructure.Data
{
    public class StoreContext(DbContextOptions options) : DbContext(options) 
    {
       public DbSet<Product> products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfigurrtion).Assembly);
        }
    }
}
