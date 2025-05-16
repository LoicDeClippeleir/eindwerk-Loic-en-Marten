using Microsoft.EntityFrameworkCore;
using Simpleschool.Models;
using SimpleSchool.Fakers;


namespace SimpleSchool.Seeders
{
    public class LeerkrachtSeeder : ISeeder
    {
        /*{
            public void Seed(ModelBuilder modelBuilder)
            {
                List<Leerkracht> leerkrachten = LeerkrachtFaker.Faker.Generate(10);
                modelBuilder.Entity<Leerkracht>().HasData(leerkrachten);
            }
        }*/
        public void Seed(ModelBuilder modelBuilder)
        {
            List<Leerkracht> leerkrachten = LeerkrachtFaker.Faker.Generate(10);
            for (int i = 0; i < leerkrachten.Count; i++)
            {
                leerkrachten[i].Id = i + 1; // Ensure IDs are 1, 2, ..., 10
            }
            modelBuilder.Entity<Leerkracht>().HasData(leerkrachten);
        }
    }

}
