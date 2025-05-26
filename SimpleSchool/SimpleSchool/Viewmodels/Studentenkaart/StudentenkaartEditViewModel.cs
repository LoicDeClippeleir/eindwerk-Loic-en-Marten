using System.ComponentModel.DataAnnotations;

namespace SimpleSchool.Viewmodels.Studentenkaart
{
    public class StudentenkaartEditViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Naam is verplicht.")]
        [StringLength(100, ErrorMessage = "Naam mag maximaal 100 tekens zijn.")]
        public string Naam { get; set; } = string.Empty;

        [Required(ErrorMessage = "Klas is verplicht.")]
        [StringLength(50, ErrorMessage = "Klas mag maximaal 50 tekens zijn.")]
        public string Klas { get; set; } = string.Empty;

        [Required(ErrorMessage = "School is verplicht.")]
        [StringLength(100, ErrorMessage = "School mag maximaal 100 tekens zijn.")]
        public string School { get; set; } = string.Empty;
    }
}

