namespace SimpleschoolApp.Models
{
    public class Leerkracht
    {
        public int Id { get; set; }
        public string  Naam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string EMail { get; set; }
        public string Adres { get; set; }
        public int VakId { get; set; }
        public Vak Vak { get; set; }
    }
}
