using System.ComponentModel.DataAnnotations;

namespace SimpleSchool.Viewmodels.Studentenkaart
{
    public class StudentenkaartCreateViewModel
    {
        [Required(ErrorMessage = "Naam is verplicht.")]
        public string Naam { get; set; } = string.Empty;

        [Required(ErrorMessage = "Klas is verplicht.")]
        public string Klas { get; set; } = string.Empty;

        [Required(ErrorMessage = "School is verplicht.")]
        public string School { get; set; } = string.Empty;
    }
}

