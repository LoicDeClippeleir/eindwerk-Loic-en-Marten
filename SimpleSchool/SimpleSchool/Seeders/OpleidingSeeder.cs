using Microsoft.EntityFrameworkCore;
using Simpleschool.Models;
using SimpleSchool.Fakers;


namespace SimpleSchool.Seeders
{
    public class OpleidingSeeder : ISeeder
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            List<Opleiding> opleidingen = OpleidingFaker.Faker.Generate(10);
            modelBuilder.Entity<Opleiding>().HasData(opleidingen);
        }
    }
}
