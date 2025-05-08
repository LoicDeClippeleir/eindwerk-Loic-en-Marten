using Microsoft.EntityFrameworkCore;
using SimpleSchool.Fakers;
using SimpleschoolApp.Models;

namespace SimpleSchool.Seeders
{
    public class StudentenkaartSeeder : ISeeder
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            List<StudentenKaart> studentenkaarten = StudentenKaartFaker.Faker.Generate(10);
            modelBuilder.Entity<StudentenKaart>().HasData(studentenkaarten);
        }
    }
}
