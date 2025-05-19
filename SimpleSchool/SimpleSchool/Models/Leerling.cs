namespace SimpleSchool.Models
{
    public class Leerling
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string  EMail { get; set; }
        public string Adres { get; set; }

        public int StudentenkaartId { get; set; }
        public Opleiding Opleiding { get; set; }
        public StudentenKaart Studentenkaart { get; set; }
        public int OpleidingId { get; set; }
    }
}
