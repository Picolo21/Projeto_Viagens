namespace Projeto_Viagens.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Neighborhood { get; set; }
        public string PostalCode { get; set; }
        public string Complement { get; set; }
        public City City { get; set; }
        public DateTime RegistrationDate { get; set; }

        public string ToStringAddress()
        {
            return $"ID: {Id}\nEndereço: {Street}\nNúmero: {Number}\n" +
                   $"Bairro: {Neighborhood}\nCEP: {PostalCode}\n" +
                   $"Complemento: {Complement}\nCidade: {City.ToStringAddress()}" +
                   $"Data de Registro: {RegistrationDate.ToString("dd/MM/yyyy")}\n\n" + 
                   $"-----------------------------------------------------------------\n";
        }

        public string ToStringClient()
        {
            return $"{Street}, {Number}\nComplemento: {Complement}\n" +
                   $"Bairro: {Neighborhood}\nCidade: {City.ToStringAddress()}";
        }
    }
}
