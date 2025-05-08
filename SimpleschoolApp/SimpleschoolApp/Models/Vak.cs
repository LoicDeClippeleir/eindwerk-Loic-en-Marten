namespace SimpleschoolApp.Models
{
    public class Vak
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Taal { get; set; }
        public int AantalStudiePunten { get; set; }
        public Type Type { get; set; }
<<<<<<< HEAD
        public int LeerkrachtId { get; set; }
        public Leerkracht Leerkracht { get; set; }
        public List<Opleiding> Opleidingen { get; set; }
=======
        public Leerkracht Leerkracht { get; set; }
        public int LeerkrachtId { get; set; }
>>>>>>> 27966b871eebe57ffd243821cc3390496f50f48d

        public List<Opleiding> Opleidingen { get; set; }
    }
    public enum Type
    {
        Theoretisch,
        Praktisch,
        
    }
}
