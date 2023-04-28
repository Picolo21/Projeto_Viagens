using System.Text;

namespace Projeto_Viagens_ADO.NET.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string? Street { get; set; }
        public int Number { get; set; }
        public string? Neighborhood { get; set; }
        public string? PostalCode { get; set; }
        public string? Complement { get; set; }
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

        public string ToStringCustomer()
        {
            return $"{Street}, {Number}\nComplemento: {Complement}\n" +
                   $"Bairro: {Neighborhood}\nCidade: {City.ToStringAddress()}";
        }

        public string ToStringHotel()
        {
            return $"{Street}, {Number}\nComplemento: {Complement}\n" +
                   $"Bairro: {Neighborhood}\nCidade: {City.ToStringAddress()}";
        }

        public string ToStringTicket()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Street + ", ");
            sb.Append(Number + ", ");
            if (Complement != "")
            {
                sb.Append(Complement + ", ");
            }
            sb.Append(Neighborhood + ", ");
            sb.Append(City.ToStringTicket());
            return sb.ToString();
        }

        public string ToStringPackage()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Street + ", ");
            sb.Append(Number + ", ");
            if (Complement != "")
            {
                sb.Append(Complement + ", ");
            }
            sb.Append(Neighborhood + ", ");
            sb.Append(City.ToStringPackage());
            return sb.ToString();

        }
    }
}
