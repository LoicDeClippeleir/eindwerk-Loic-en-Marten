namespace SimpleschoolApp.Models
{
    public class Leerling
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string  EMail { get; set; }
        public string Adres { get; set; }
        public int StudentenKaartId { get; set; }
        public StudentenKaart StudentenKaart { get; set; }
        public List<Opleiding> Opleidingen { get; set; }
    }
}
