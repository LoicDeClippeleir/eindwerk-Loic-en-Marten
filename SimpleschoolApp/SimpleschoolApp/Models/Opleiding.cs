namespace SimpleschoolApp.Models
{
    public class Opleiding
    {
        public int Id { get; set; }
        public string  Naam { get; set; }
        public int  Duur { get; set; }
        public int BeschikbarePlaatsen { get; set; }
        public string Beschrijving { get; set; }
<<<<<<< HEAD
        public List<Leerling> Leerlingen { get; set; }
        public List<Vak> Vakken { get; set; }
=======
        public List<Vak> Vakken { get; set; }
        public List<Leerling> Leerlingen { get; set; }
>>>>>>> 27966b871eebe57ffd243821cc3390496f50f48d
    }
}
