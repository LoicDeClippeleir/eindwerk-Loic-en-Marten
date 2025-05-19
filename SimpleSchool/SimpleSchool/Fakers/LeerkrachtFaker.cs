using Bogus;
using SimpleSchool.Models;



namespace SimpleSchool.Fakers
{
    public class LeerkrachtFaker
    {
        public static readonly Faker<Leerkracht> Faker = new Faker<Leerkracht>("nl")
            .RuleFor(l => l.Id, f => f.IndexFaker + 1)
            .RuleFor(l => l.Naam, f => f.Name.FullName())
            .RuleFor(l => l.GeboorteDatum, f => f.Date.Past())
            .RuleFor(l => l.EMail, f => f.Lorem.Word())
            .RuleFor(l => l.Adres, f => f.Address.StreetAddress());
    }
}




