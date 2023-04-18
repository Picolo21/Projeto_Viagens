namespace Projeto_Viagens.Models
{
    public class Package
    {
        public int Id { get; set; }
        public Hotel Hotel { get; set; }
        public Ticket Ticket { get; set; }
        public DateTime RegistrationDate { get; set; }
        public double Value { get; set; }
        public Client Client { get; set; }
    }
}
