using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Core.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Infrastructure.Layer.Configurations
{
    internal class Uye_CFG : IEntityTypeConfiguration<Uye>
    {
        public void Configure(EntityTypeBuilder<Uye> builder)
        {
            var uye = new Uye()
            {
                Id = 1,
                UserName = "superUser",
                NormalizedUserName = "SUPERUSER",
                Email = "superuser@deneme.com",
                NormalizedEmail = "SUPERUSER@DENEME.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = false,
                Adres = "Kadikoy"

            };

            PasswordHasher<Uye> passwordHasher = new PasswordHasher<Uye>();
            uye.PasswordHash = passwordHasher.HashPassword(uye, "spRuser_123");

            builder.HasData(uye);

        }
    }
}
