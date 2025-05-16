using Microsoft.EntityFrameworkCore;

namespace SimpleSchool.Seeders
{
    public class DbSeeder : ISeeder
    {
        
        public void Seed(ModelBuilder modelBuilder)
        {
            List<ISeeder> seeders = new() { new LeerkrachtSeeder(),new LeerlingSeeder(), new StudentenkaartSeeder(), new OpleidingSeeder(), new VakSeeder() };
            seeders.ForEach(seeder => seeder.Seed(modelBuilder));
        }
    }
}
    