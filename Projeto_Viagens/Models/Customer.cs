namespace Projeto_Viagens_ADO.NET.Models
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

        public string ToStringPackage()
        {
            return $"{CustomerName}";
        }
    }
}
