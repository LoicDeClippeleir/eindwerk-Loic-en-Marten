using Bogus;
using Simpleschool.Models;



namespace SimpleSchool.Fakers
{
    public class LeerkrachtFaker
    {
        public  Faker<Leerkracht> Faker = new Faker<Leerkracht>("nl")
            .RuleFor(l => l.Id, f => f.IndexFaker + 1)
            .RuleFor(l => l.Naam, f => f.Lorem.Sentence(20))
            .RuleFor(l => l.GeboorteDatum, f => f.Date.Past())
            .RuleFor(l => l.EMail, f => f.Lorem.Word())
            .RuleFor(l => l.Adres, f => f.Address.StreetAddress());
    }
}




