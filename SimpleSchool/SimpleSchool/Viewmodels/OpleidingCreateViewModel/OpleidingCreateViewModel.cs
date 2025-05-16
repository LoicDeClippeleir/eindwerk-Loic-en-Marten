using Simpleschool.Models;

namespace SimpleSchool.Viewmodels.OpleidingCreateViewModel
{
    public class OpleidingCreateViewModel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Duur { get; set; }
        public int BeschikbarePlaatsen { get; set; }
        public string Beschrijving { get; set; }
        //public List<Leerling> Leerlingen { get; set; }
        public List<Vak> Vakken { get; set; }
    }
}
