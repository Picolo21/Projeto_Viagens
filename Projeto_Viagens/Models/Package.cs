namespace Projeto_Viagens_ADO.NET.Models
{
    public class Package
    {
        public int Id { get; set; }
        public Hotel Hotel { get; set; }
        public Ticket Ticket { get; set; }
        public DateTime RegistrationDate { get; set; }
        public decimal PackageValue { get; set; }
        public Customer Customer { get; set; }

        public string ToStringPackage()
        {
            return $"ID: {Id}\nHotel: {Hotel.ToStringPackage()}\n" + 
                   $"{Ticket.ToStringPackage()}\n" +
                   $"Data de Registro: {RegistrationDate.ToString("dd/MM/yyyy")}\n" +
                   $"Valor do Pacote: R$ {PackageValue.ToString("F2")}\n" +
                   $"Cliente: {Customer.ToStringPackage()}\n\n" +
                   $"-----------------------------------------------------------------\n";
        }
    }
}
