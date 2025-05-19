using Bogus;
using SimpleSchool.Models;


namespace SimpleSchool.Fakers
{
    public class OpleidingFaker
    {
        public  Faker<Opleiding> Faker = new Faker<Opleiding>("nl")
           .RuleFor(l => l.Id, f => f.IndexFaker + 1)
           .RuleFor(l => l.Naam, f => f.Lorem.Sentence(20))
           .RuleFor(l => l.Duur, f => f.Random.Number(3,4))
           .RuleFor(l => l.BeschikbarePlaatsen,  f => f.Random.Number(200, 400))
           .RuleFor(l => l.Beschrijving, f => f.Lorem.Sentence(20));
    }
}
