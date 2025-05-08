using System.Globalization;

namespace SimpleschoolApp.Models
{
    public class StudentenKaart
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Klas { get; set; }
        public string  School { get; set; }
        public Leerling Leerling { get; set; }
    }
}
