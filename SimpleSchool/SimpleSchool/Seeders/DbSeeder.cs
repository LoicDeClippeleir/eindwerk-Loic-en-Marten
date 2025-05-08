using Microsoft.EntityFrameworkCore;

namespace SimpleSchool.Seeders
{
    public class DbSeeder : ISeeder
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            List<ISeeder> seeders = new() { new LeerkreachtSeeder(), new LeerlingSeeder(), new VakSeeder(), new StudentenkaartSeeder(), new OpleidingSeeder() };
            seeders.ForEach(seeder => seeder.Seed(modelBuilder));
        }
    }
}
