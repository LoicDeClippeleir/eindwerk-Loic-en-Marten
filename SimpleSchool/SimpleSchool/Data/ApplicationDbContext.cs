using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleschoolApp.Models;

namespace SimpleSchool.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SimpleschoolApp.Models.Leerkracht> Leerkracht { get; set; } = default!;
        public DbSet<SimpleschoolApp.Models.Leerling> Leerling { get; set; } = default!;
        public DbSet<SimpleschoolApp.Models.Opleiding> Opleiding { get; set; } = default!;
        public DbSet<SimpleschoolApp.Models.StudentenKaart> StudentenKaart { get; set; } = default!;
        public DbSet<SimpleschoolApp.Models.Vak> Vak { get; set; } = default!;
    }
}
