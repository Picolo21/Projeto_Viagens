namespace Projeto_Viagens.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
