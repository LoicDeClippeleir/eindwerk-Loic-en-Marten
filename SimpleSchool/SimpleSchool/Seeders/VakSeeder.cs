using Microsoft.EntityFrameworkCore;
using SimpleSchool.Models;
using SimpleSchool.Fakers;


namespace SimpleSchool.Seeders
{
    public class VakSeeder : ISeeder
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            List<Vak> vakken = VakFaker.Faker.Generate(10);
            modelBuilder.Entity<Vak>().HasData(vakken);
        }
    }
}
