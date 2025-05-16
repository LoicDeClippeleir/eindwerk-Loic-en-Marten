using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleSchool.Viewmodels
{
    // Deze attribute kun je op een DateTime-property zetten om een minimumleeftijd af te dwingen.
    public class MinAgeAttribute : ValidationAttribute
    {
        // Field om de minimumleeftijd op te slaan.
        private readonly int _minAge;

        // Constructor: hiermee geef je aan wat de minimumleeftijd moet zijn.
        public MinAgeAttribute(int minAge)
        {
            _minAge = minAge;
            // Standaard foutmelding als de validatie faalt.
            ErrorMessage = $"Je moet minimaal {_minAge} jaar oud zijn.";
        }

        // Deze methode voert de daadwerkelijke validatie uit.
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // Controleer of de waarde een geldige geboortedatum is.
            if (value is DateTime geboortedatum)
            {
                var today = DateTime.Today;
                // Bereken de leeftijd op basis van het huidige jaar en het geboortejaar.
                var age = today.Year - geboortedatum.Year;
                // Corrigeer de leeftijd als de verjaardag dit jaar nog niet is geweest.
                if (geboortedatum.Date > today.AddYears(-age)) age--;

                // Als de leeftijd kleiner is dan de minimumleeftijd, geef een foutmelding terug.
                if (age < _minAge)
                {
                    return new ValidationResult(ErrorMessage);
                }
            }
            // Als alles in orde is, geef aan dat de validatie geslaagd is.
            return ValidationResult.Success;
        }
    }
}

