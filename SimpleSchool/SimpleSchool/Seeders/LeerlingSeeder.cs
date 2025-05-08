using Microsoft.EntityFrameworkCore;
using SimpleSchool.Fakers;
using SimpleschoolApp.Models;

namespace SimpleSchool.Seeders
{
    public class LeerlingSeeder : ISeeder
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            List<Leerling> leerlingen = LeerlingFaker.Faker.Generate(10);
            modelBuilder.Entity<Leerling>().HasData(leerlingen);
        }
    }
}
