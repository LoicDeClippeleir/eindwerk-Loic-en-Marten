using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleschoolApp.Models;

namespace SimpleschoolApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Leerkracht>().HasMany( l => l.Vak)
            base.OnModelCreating(builder);
        }
        public DbSet<SimpleschoolApp.Models.Leerkracht> Leerkracht { get; set; } = default!;
        public DbSet<SimpleschoolApp.Models.Leerling> Leerling { get; set; } = default!;
        public DbSet<SimpleschoolApp.Models.Opleiding> Opleiding { get; set; } = default!;
        public DbSet<SimpleschoolApp.Models.StudentenKaart> StudentenKaart { get; set; } = default!;
        public DbSet<SimpleschoolApp.Models.Vak> Vak { get; set; } = default!;
    }
}
