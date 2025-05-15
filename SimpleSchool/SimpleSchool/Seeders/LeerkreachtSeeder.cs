using Microsoft.EntityFrameworkCore;
using Simpleschool.Models;
using SimpleSchool.Fakers;


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
