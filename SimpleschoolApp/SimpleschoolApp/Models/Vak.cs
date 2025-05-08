namespace SimpleschoolApp.Models
{
    public class Vak
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Taal { get; set; }
        public int AantalStudiePunten { get; set; }
        public Type Type { get; set; }

    }
    public enum Type
    {
        Theoretisch,
        Praktisch
        
    }
}
