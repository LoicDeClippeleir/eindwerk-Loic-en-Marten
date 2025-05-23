using System.ComponentModel.DataAnnotations;

namespace SimpleSchool.Viewmodels.Leerkracht
{
    public class LeerkrachtEditViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Naam is verplicht.")]
        [StringLength(100, ErrorMessage = "Naam mag maximaal 100 tekens zijn.")]
        public string Naam { get; set; } = string.Empty;

        [Required(ErrorMessage = "Geboortedatum is verplicht.")]
        [MinAge(18, ErrorMessage = "Je moet minimaal 18 jaar oud zijn.")]
        public DateTime GeboorteDatum { get; set; }

        [Required(ErrorMessage = "E-mailadres is verplicht.")]
        [EmailAddress(ErrorMessage = "Ongeldig e-mailadres.")]
        public string EMail { get; set; } = string.Empty;

        [Required(ErrorMessage = "Adres is verplicht.")]
        [StringLength(200, ErrorMessage = "Adres mag maximaal 200 tekens zijn.")]
        public string Adres { get; set; } = string.Empty;

        [Required(ErrorMessage = "Selecteer minstens één vak.")]
        public List<int> VakkenIds { get; set; } = new List<int>();
    }
}
