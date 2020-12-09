using DiarsFinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsFinal.BD.Maps
{
  
        public class DetallePostTagMap : IEntityTypeConfiguration<DetallePostTags>
        {
        //Este es uno solo
        public void Configure(EntityTypeBuilder<DetallePostTags> builder)
        {

            builder.ToTable("DetallePostTags");
            builder.HasKey(x => x.Id);

            builder.HasOne(a => a.Tag).WithMany(a => a.DetallePostTags).
                HasForeignKey(a => a.IdTags);

            builder.HasOne(o => o.Post).WithMany(o => o.DetallePostTags)
                .HasForeignKey(o => o.IdPost);
        }
    }
}
