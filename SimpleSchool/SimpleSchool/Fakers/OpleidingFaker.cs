using Bogus;
using SimpleschoolApp.Models;

namespace SimpleSchool.Fakers
{
    public class OpleidingFaker
    {
        public static readonly Faker<Opleiding>("nl") Faker = new Faker<Opleiding>()
           .RuleFor(l => l.Id, f => f.IndexFaker + 1)
           .RuleFor(l => l.Naam, f => f.Lorem.Sentence(20))
           .RuleFor(l => l.Duur, f => f.Random.Number(3,4))
           .RuleFor(l => l.BeschikbarePlaatsen,  f => f.Random.Number(200, 400))
           .RuleFor(l => l.Beschrijving, f => f.Lorem.Sentence(20));
    }
}
