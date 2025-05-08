using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using Onion.Core.Layer.Entities;
using Onion.Infrastructure.Layer.Configurations.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Infrastructure.Layer.Configurations
{
    internal class Urun_CFG : BaseConfiguration<Urun>, IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.UrunAdi).HasColumnType("nvarchar").HasMaxLength(150);
            builder.Property(x => x.UrunResmi).HasColumnType("nvarchar").HasMaxLength(100);
            builder.Property(x => x.Fiyat).HasColumnType("money");
        }
    }
}
