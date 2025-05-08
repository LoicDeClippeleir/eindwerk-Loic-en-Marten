using Microsoft.EntityFrameworkCore;
using SimpleSchool.Fakers;
using SimpleschoolApp.Models;

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
