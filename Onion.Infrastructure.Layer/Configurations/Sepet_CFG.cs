using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Core.Layer.Entities;
using Onion.Infrastructure.Layer.Configurations.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Infrastructure.Layer.Configurations
{
    internal class Sepet_CFG : BaseConfiguration<Sepet>, IEntityTypeConfiguration<Sepet>
    {
        public void Configure(EntityTypeBuilder<Sepet> builder)
        {
            base.Configure(builder);       
            
        }
    }
}
