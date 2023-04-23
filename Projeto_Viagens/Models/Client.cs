using System.IO;

namespace Projeto_Viagens.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public DateTime RegistrationDate { get; set; }

        public string ToStringClient()
        {
            return $"ID: {Id}\nNome: {ClientName}\nTelefone: {Phone}\n" +
                   $"Endreço: {Address.ToStringClient()}" +
                   $"Data de Registro: {RegistrationDate.ToString("dd/MM/yyyy")}\n\n" +
                   $"-----------------------------------------------------------------\n";
        }
    }
}
