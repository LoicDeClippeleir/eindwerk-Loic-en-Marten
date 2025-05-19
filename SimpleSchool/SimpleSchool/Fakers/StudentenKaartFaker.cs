using Bogus;
using SimpleSchool.Models;


namespace SimpleSchool.Fakers
{
    public class StudentenKaartFaker
    {
        public static readonly Faker<StudentenKaart> Faker =  new Faker<StudentenKaart>("nl").RuleFor(l => l.Id, f => f.IndexFaker + 1)
                                                                                         .RuleFor(l => l.Naam, f => f.Name.FindName())
                                                                                         .RuleFor(l => l.School, f => f.Company.CompanyName())
                                                                                         .RuleFor(l=> l.Klas, f=> f.Lorem.Word())
                                                                                         ;

    }
}
