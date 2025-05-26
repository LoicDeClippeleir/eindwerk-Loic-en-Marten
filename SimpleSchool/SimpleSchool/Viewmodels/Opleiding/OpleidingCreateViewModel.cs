using System.ComponentModel.DataAnnotations;

namespace SimpleSchool.Viewmodels.Opleiding
{
    public class OpleidingCreateViewModel
    {
        [Required(ErrorMessage = "Naam is verplicht.")]
        [StringLength(100, ErrorMessage = "Naam mag maximaal 100 tekens zijn.")]
        public string Naam { get; set; } = string.Empty;

        [Required(ErrorMessage = "Duur is verplicht.")]
        [Range(1, 5, ErrorMessage = "Duur moet tussen 1 en 5 jaar zijn.")]
        public int Duur { get; set; }

        [Required(ErrorMessage = "Beschikbare plaatsen zijn verplicht.")]
        [Range(1, 1000, ErrorMessage = "Beschikbare plaatsen moeten tussen 1 en 1000 zijn.")]
        public int BeschikbarePlaatsen { get; set; }

        [Required(ErrorMessage = "Beschrijving is verplicht.")]
        [StringLength(1000, ErrorMessage = "Beschrijving mag maximaal 1000 tekens zijn.")]
        public string Beschrijving { get; set; } = string.Empty;
    }
}

