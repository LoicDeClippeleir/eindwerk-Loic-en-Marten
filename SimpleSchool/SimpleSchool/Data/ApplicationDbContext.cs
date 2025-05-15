using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleSchool.Seeders;
using SimpleschoolApp.Models;

namespace SimpleSchool.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            new DbSeeder().Seed(builder);
            builder.Entity<Leerkracht>().HasMany(l => l.Vakken).WithOne(l => l.Leerkracht);
            builder.Entity<Leerling>().HasOne(l => l.Studentenkaart).WithOne(k => k.Leerling);
            builder.Entity<Leerling>().HasOne(l=> l.Opleiding).WithMany(k=> k.Leerlingen).HasForeignKey(l => l.OpleidingId);
            builder.Entity<Opleiding>().HasMany(l=> l.Vakken).WithMany(k=> k.Opleidingen).UsingEntity(j => j.ToTable("Opleidingsvakken"));
            base.OnModelCreating(builder);
        }
        public DbSet<SimpleschoolApp.Models.Leerkracht> Leerkrachten { get; set; } = default!;
        public DbSet<SimpleschoolApp.Models.Leerling> Leerlingen { get; set; } = default!;
        public DbSet<SimpleschoolApp.Models.Opleiding> Opleidingen { get; set; } = default!;
        public DbSet<SimpleschoolApp.Models.StudentenKaart> StudentenKaarten { get; set; } = default!;
        public DbSet<SimpleschoolApp.Models.Vak> Vakken { get; set; } = default!;
    }
}
