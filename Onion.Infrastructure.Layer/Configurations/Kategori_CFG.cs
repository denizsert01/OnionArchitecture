using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
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
    internal class Kategori_CFG : BaseConfiguration<Kategori>, IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.KategoriAdi).HasColumnType("nvarchar").HasMaxLength(30);
                

            builder.HasData(
                new Kategori
                { 
                    KategoriID = 1,
                    KategoriAdi = "Telefon"

                },
               new Kategori
               {
                   KategoriID = 2,
                   KategoriAdi = "Hediyelik Esya"

               },
               new Kategori
               {
                   KategoriID = 3,
                   KategoriAdi = "Hobi"

               }
            );
        }
    } 
}
