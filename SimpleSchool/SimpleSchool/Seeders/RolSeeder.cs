using Bogus.DataSets;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SimpleSchool.Seeders
{
    public class RolSeeder : ISeeder
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData( new IdentityRole { Name = "Leerling", NormalizedName = "LEERLING" }, 
                                                         new IdentityRole { Name = "Leerkracht", NormalizedName = "LEERKRACHT"},
                                                         new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" });
        }
    }
}
