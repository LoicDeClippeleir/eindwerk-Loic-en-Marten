using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simpleschool.Models;
using SimpleSchool.Seeders;

namespace SimpleSchool.Data
{
    public class SimpleSchoolContext : DbContext
    {
        public SimpleSchoolContext (DbContextOptions<SimpleSchoolContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new DbSeeder().Seed(modelBuilder);
            modelBuilder.Entity<Leerkracht>().HasMany(v => v.Vakken).WithOne(l => l.Leerkracht).HasForeignKey(v => v.LeerkrachtId) ;
            modelBuilder.Entity<Leerling>().HasOne(l => l.Studentenkaart).WithOne(k => k.Leerling).HasForeignKey<Leerling>(l => l.StudentenkaartId);

            modelBuilder.Entity<Leerling>().HasOne(l => l.Opleiding).WithMany(k => k.Leerlingen).HasForeignKey(l => l.OpleidingId);
            modelBuilder.Entity<Opleiding>().HasMany(l => l.Vakken).WithMany(k => k.Opleidingen).UsingEntity(j => j.ToTable("Opleidingsvakken"));
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Simpleschool.Models.Leerkracht> Leerkracht { get; set; } = default!;
        public DbSet<Simpleschool.Models.Leerling> Leerling { get; set; } = default!;
        public DbSet<Simpleschool.Models.Opleiding> Opleiding { get; set; } = default!;
        public DbSet<Simpleschool.Models.StudentenKaart> StudentenKaart { get; set; } = default!;
        public DbSet<Simpleschool.Models.Vak> Vak { get; set; } = default!;
    }
}
