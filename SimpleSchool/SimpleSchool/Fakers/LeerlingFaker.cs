using Bogus;
using SimpleschoolApp.Models;

namespace SimpleSchool.Fakers
{
    public class LeerlingFaker
    {
        public static readonly Faker<Leerling>("nl") Faker = new Faker<Leerling>()
           .RuleFor(l => l.Id, f => f.IndexFaker + 1)
           .RuleFor(l => l.Naam, f => f.Lorem.Sentence(20))
           .RuleFor(l => l.GeboorteDatum, f => f.Date.Past())
           .RuleFor(l => l.EMail, f => f.Lorem.Word())
           .RuleFor(l => l.Adres, f => f.Address.StreetAddress())
           .RuleFor(l => l.StudentenkaartId, f => f.IndexFaker + 1)
           .RuleFor(l => l.OpleidingId, f => f.IndexFaker + 1);

    }
}
