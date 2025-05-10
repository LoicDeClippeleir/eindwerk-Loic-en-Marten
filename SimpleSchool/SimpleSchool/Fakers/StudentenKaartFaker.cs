using Bogus;
using SimpleschoolApp.Models;

namespace SimpleSchool.Fakers
{
    public class StudentenKaartFaker
    {
        public static readonly Faker<StudentenKaart>("nl") Faker =  new Faker<StudentenKaart>().RuleFor(l => l.Id, f => f.IndexFaker + 1)
                                                                                         .RuleFor(l => l.Naam, f => f.Name.FindName())
                                                                                         .RuleFor(l => l.School, f => f.Company.CompanyName())
                                                                                         .RuleFor(l=> l.Klas, f=> f.Lorem.Word())
                                                                                         ;

    }
}
