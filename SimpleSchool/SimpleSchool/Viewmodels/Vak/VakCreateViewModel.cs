using SimpleSchool.Models;
using System.ComponentModel.DataAnnotations;

namespace SimpleSchool.Viewmodels.Vak
{
    public class VakCreateViewModel
    {
        [Required(ErrorMessage = "Naam is verplicht.")]
        [StringLength(100, ErrorMessage = "Naam mag maximaal 100 tekens zijn.")]
        public string Naam { get; set; } = string.Empty;

        [Required(ErrorMessage = "Taal is verplicht.")]
        [StringLength(50, ErrorMessage = "Taal mag maximaal 50 tekens zijn.")]
        public string Taal { get; set; } = string.Empty;

        [Required(ErrorMessage = "Aantal studiepunten is verplicht.")]
        [Range(1, 100, ErrorMessage = "Aantal studiepunten moet tussen 1 en 100 zijn.")]
        public int AantalStudiePunten { get; set; }

        [Required(ErrorMessage = "Vaktype is verplicht.")]
        public VakType Vaktype { get; set; }

        [Required(ErrorMessage = "Leerkracht is verplicht.")]
        public int LeerkrachtId { get; set; }
    }
}
