using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Onion.Core.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Infrastructure.Layer.DataContext
{
    /// <summary>
    ///  tools, ef core, sqlserver paketlerini yükledik
    /// </summary>
    internal class UrunDbContext : IdentityDbContext<Uye, Rol, int>
    {
        public UrunDbContext(DbContextOptions options) : base(options)
        {
        }

        public UrunDbContext()
        {
        }

        public DbSet<Sepet> Sepetler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }

        // Connection String burada verilir. Migration için. 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog = YY2_UrunDBSepet; Integrated security= true; trust server certificate = true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Uye rol ilişkisi unutma
            builder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int>
                {
                    RoleId = 1,
                    UserId = 1
                }
            );

        }
    }
}
