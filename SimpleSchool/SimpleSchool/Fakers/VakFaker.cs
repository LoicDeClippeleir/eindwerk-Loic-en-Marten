using Bogus;
using SimpleSchool.Models;


namespace SimpleSchool.Fakers
{
    public class VakFaker
    {
        public static readonly Faker<Vak> Faker = new Faker<Vak>("nl").RuleFor(l => l.Id, f => f.IndexFaker + 1)
                                                                  .RuleFor(l => l.Naam, f => f.Lorem.Word())
                                                                  .RuleFor(l => l.AantalStudiePunten, f => f.Random.Number(10, 50))
                                                                  .RuleFor(l => l.Vaktype, f => f.Random.Enum<VakType>())
                                                                  .RuleFor(l=> l.Taal, f=> f.Lorem.Word())
                                                                  .RuleFor(l => l.LeerkrachtId, f => f.IndexFaker +1)
                                                                  ;
                        
                                                                  
    }
}
