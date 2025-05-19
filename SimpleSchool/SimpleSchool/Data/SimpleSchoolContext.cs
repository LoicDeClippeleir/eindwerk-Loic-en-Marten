using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleSchool.Models;
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

            modelBuilder.Entity<Leerkracht>().HasMany(v => v.Vakken).WithOne(l => l.Leerkracht).HasForeignKey(v => v.LeerkrachtId);
            modelBuilder.Entity<Leerling>().HasOne(l => l.Studentenkaart).WithOne(k => k.Leerling).HasForeignKey<Leerling>(l => l.StudentenkaartId);

            modelBuilder.Entity<Leerling>().HasOne(l => l.Opleiding).WithMany(k => k.Leerlingen).HasForeignKey(l => l.OpleidingId);
            modelBuilder.Entity<Opleiding>().HasMany(l => l.Vakken).WithMany(k => k.Opleidingen).UsingEntity(j => j.ToTable("Opleidingsvakken"));
            new DbSeeder().Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<SimpleSchool.Models.Leerkracht> Leerkracht { get; set; } = default!;
        public DbSet<SimpleSchool.Models.Leerling> Leerling { get; set; } = default!;
        public DbSet<SimpleSchool.Models.Opleiding> Opleiding { get; set; } = default!;
        public DbSet<SimpleSchool.Models.StudentenKaart> StudentenKaart { get; set; } = default!;
        public DbSet<SimpleSchool.Models.Vak> Vak { get; set; } = default!;
    }
}
