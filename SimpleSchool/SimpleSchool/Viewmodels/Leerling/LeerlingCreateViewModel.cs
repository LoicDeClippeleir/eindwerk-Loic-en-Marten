using Simpleschool.Models;
using System.ComponentModel.DataAnnotations;

namespace SimpleSchool.Viewmodels.Leerling
{
    public class LeerlingCreateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Naam is verplicht.")]
        public string   Naam { get; set; }
        [Required(ErrorMessage = "Geboortedatum is verplicht.")]
        public DateTime GeboorteDatum { get; set; }
        [Required(ErrorMessage = "E-mailadres is verplicht.")]
        [EmailAddress(ErrorMessage = "Ongeldig e-mailadres.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Adres is verplicht.")]
        public string Adres { get; set; }
        
        [Required(ErrorMessage = "Selecteer  een studentenkaart.")]
        public List<StudentenKaart> StudentenKaartId { get; set; }
        [Required(ErrorMessage = "Selecteer  een opleiding.")]
        public List<Opleiding> OpleidingId { get; set; }
    }
}
