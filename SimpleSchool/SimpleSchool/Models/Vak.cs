namespace SimpleschoolApp.Models
{
    public class Vak
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Taal { get; set; }
        public int AantalStudiePunten { get; set; }
        public VakType Vaktype { get; set; }

        public int LeerkrachtId { get; set; }
        public Leerkracht Leerkracht { get; set; }
        public List<Opleiding> Opleidingen { get; set; }
    }
    public enum VakType
    {
        Theoretisch,
        Praktisch,
        
    }
}
