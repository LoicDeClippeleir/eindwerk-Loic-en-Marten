using Microsoft.EntityFrameworkCore;
using SimpleSchool.Models;
using SimpleSchool.Fakers;


namespace SimpleSchool.Seeders
{
    public class LeerkrachtSeeder : ISeeder
    {
        
            public void Seed(ModelBuilder modelBuilder)
            {
                List<Leerkracht> leerkrachten = LeerkrachtFaker.Faker.Generate(10);
                modelBuilder.Entity<Leerkracht>().HasData(leerkrachten);
            }
        
        
    }

}
