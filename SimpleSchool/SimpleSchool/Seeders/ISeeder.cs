using Microsoft.EntityFrameworkCore;

namespace SimpleSchool.Seeders
{
    public interface ISeeder
    {
        public void Seed(ModelBuilder modelBuilder);
    }
}
