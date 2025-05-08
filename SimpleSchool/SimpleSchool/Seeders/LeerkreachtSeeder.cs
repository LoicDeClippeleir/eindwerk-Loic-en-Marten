using Microsoft.EntityFrameworkCore;
using SimpleSchool.Fakers;
using SimpleschoolApp.Models;

namespace SimpleSchool.Seeders
{
    public class LeerkreachtSeeder : ISeeder
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            List<Leerkracht> leerkrachten = LeerkrachtFaker.Faker.Generate(10);
            modelBuilder.Entity<Leerkracht>().HasData(leerkrachten);
        }
    }
}
