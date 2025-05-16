using Bogus;
using Simpleschool.Models;


namespace SimpleSchool.Fakers
{
    public class VakFaker
    {
        public static readonly Faker<Vak> Faker = new Faker<Vak>("nl").RuleFor(l => l.Id, f => f.IndexFaker + 1)
                                                                  .RuleFor(l => l.Naam, f => f.Name.FindName())
                                                                  .RuleFor(l => l.AantalStudiePunten, f => f.Random.Number(10, 50))
                                                                  .RuleFor(l => l.Vaktype, f => f.Random.Enum<VakType>())
                                                                  .RuleFor(l=> l.Taal, f=> f.Random.Word())
                                                                  .RuleFor(l => l.LeerkrachtId, f => f.IndexFaker + 1)
                                                                  ;
                        
                                                                  
    }
}
