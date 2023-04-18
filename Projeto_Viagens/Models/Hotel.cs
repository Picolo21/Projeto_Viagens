namespace Projeto_Viagens.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public DateTime RegistrationDate { get; set; }
        public double Value { get; set; }
    }
}
