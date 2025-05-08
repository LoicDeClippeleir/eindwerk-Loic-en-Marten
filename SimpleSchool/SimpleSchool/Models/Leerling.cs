namespace SimpleschoolApp.Models
{
    public class Leerling
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string  EMail { get; set; }
        public string Adres { get; set; }
<<<<<<< HEAD
        public int StudentenkaartId { get; set; }
        public Opleiding Opleiding { get; set; }
        public StudentenKaart Studentenkaart { get; set; }
=======
        public int StudentenKaartId { get; set; }
        public StudentenKaart StudentenKaart { get; set; }
        public Opleiding Opleiding { get; set; }
>>>>>>> 27966b871eebe57ffd243821cc3390496f50f48d
        public int OpleidingId { get; set; }
    }
}
