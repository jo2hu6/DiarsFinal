using DiarsFinal.BD.Maps;
using DiarsFinal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsFinal.BD
{
    public class SimuladorContext : DbContext
    {
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Post> Posts{ get; set; }
        public DbSet<DetallePostTags> DetallePostTages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=JOSUERIVERA\\SQLEXPRESS; DataBase=Simulacro;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
           modelBuilder.ApplyConfiguration(new DetallePostTagMap());
            modelBuilder.ApplyConfiguration(new PostMap());
            modelBuilder.ApplyConfiguration(new TagMap());
        }
    }
}