using Bogus;
using Microsoft.EntityFrameworkCore;

namespace SimpleSchool.Seeders
{
    public class DbSeeder : ISeeder
    {
        public DbSeeder()
        {
            Randomizer.Seed = new Random(11234);
        }
        public void Seed(ModelBuilder modelBuilder)
        {
            List<ISeeder> seeders = new() { new LeerlingSeeder(), new StudentenkaartSeeder(), new OpleidingSeeder(), new VakSeeder(), new LeerkrachtSeeder() };
            seeders.ForEach(seeder => seeder.Seed(modelBuilder));
        }
    }
}
    