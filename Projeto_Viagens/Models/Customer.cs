using System.IO;

namespace Projeto_Viagens.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public string? Phone { get; set; }
        public Address? Address { get; set; }
        public DateTime RegistrationDate { get; set; }

        public string ToStringCustomer()
        {
            return $"ID: {Id}\nNome: {CustomerName}\nTelefone: {Phone}\n" +
                   $"Endreço: {Address.ToStringCustomer()}" +
                   $"Data de Registro: {RegistrationDate.ToString("dd/MM/yyyy")}\n\n" +
                   $"-----------------------------------------------------------------\n";
        }
    }
}
