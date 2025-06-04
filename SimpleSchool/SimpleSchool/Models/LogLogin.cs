namespace SimpleSchool.Models
{
    public class LogLogin
    {
        public int Id { get; set; }
        public int LeerlingId { get; set; }
        public DateTime LoginTime { get; set; }
        public Leerling Leerling { get; set; }
    }
}
