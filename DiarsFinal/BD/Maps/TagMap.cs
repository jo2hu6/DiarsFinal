using DiarsFinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsFinal.BD.Maps
{
    //Este para varios
    public class TagMap : IEntityTypeConfiguration<Tag>
    {

        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tag");
            builder.HasKey(x => x.Id);

            builder.HasMany(o => o.DetallePostTags)
                .WithOne(o => o.Tag)
                .HasForeignKey(o => o.IdTags);
        }
    }
}
