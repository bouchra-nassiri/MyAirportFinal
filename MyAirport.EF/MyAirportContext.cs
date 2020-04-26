using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MyAirport.EF
{
    public class MyAirportContext : DbContext
    {

        public DbSet<Vol> Vols { get; set; }
        public DbSet<Bagage> Bagages { get; set; }

        public MyAirportContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql("Server=localhost;port=8889;Database=MyAirport;uid=myairport;pwd=myairport");
        }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            

            modelBuilder.Entity<Vol>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.cie).IsRequired();
                entity.Property(e => e.jex).IsRequired();
                entity.Property(e => e.pax).IsRequired();
                entity.Property(e => e.lig).IsRequired();
                entity.Property(e => e.pkg).IsRequired();
                entity.Property(e => e.des).IsRequired();
                entity.Property(e => e.imm).IsRequired();
                entity.Property(e => e.dhc).IsRequired();
            });

            modelBuilder.Entity<Bagage>(entity =>
            {
                entity.HasKey(e => e.bagageID);
                entity.HasOne(e => e.volID);
                entity.Property(e => e.codeIATA).IsRequired();
                entity.Property(e => e.classe).IsRequired();
                entity.Property(e => e.sta).IsRequired();
                entity.Property(e => e.ssur).IsRequired();
                entity.Property(e => e.destination).IsRequired();
                entity.Property(e => e.escale).IsRequired();
                entity.Property(e => e.prioritaire).IsRequired();
                entity.Property(e => e.dateCreation).IsRequired();

            });
            
        }*/

    }
}
