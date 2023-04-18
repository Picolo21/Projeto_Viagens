namespace Projeto_Viagens.Models
{
    public class Ticket
    {
        public Address Origin { get; set; }
        public Address Destination { get; set; }
        public Client Client { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
    }
}
