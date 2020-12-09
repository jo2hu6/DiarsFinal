using DiarsFinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsFinal.BD.Maps
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        //Este es uno solo
        public void Configure(EntityTypeBuilder<Post> builder)
        {

            builder.ToTable("Post");
            builder.HasKey(x => x.Id);

            builder.HasMany(o => o.DetallePostTags)
                .WithOne(o => o.Post)
                .HasForeignKey(o => o.IdPost);

        }
    }
}
