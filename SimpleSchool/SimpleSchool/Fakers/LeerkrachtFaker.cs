using Bogus;
using SimpleschoolApp.Models;

namespace SimpleSchool.Fakers
{
    public class LeerkrachtFaker
    {
        public static readonly Faker<Leerkracht>("nl") Faker = new Faker<Leerkracht>()
            .RuleFor(l => l.Id, f => f.IndexFaker + 1)
            .RuleFor(l => l.Naam, f => f.Lorem.Sentence(20))
            .RuleFor(l => l.GeboorteDatum, f => f.Date.Past())
            .RuleFor(l => l.EMail, f => f.Lorem.Word())
            .RuleFor(l => l.Adres, f => f.Address.StreetAddress());
    }
}




