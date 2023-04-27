namespace Projeto_Viagens.Models
{
    public class City
    {
        public int Id { get; set; }
        public string? CityName { get; set; }
        public DateTime RegistrationDate { get; set; }

        public string ToStringCity()
        {
            return $"ID: {Id}\nNome: {CityName}\nData de Registro: {RegistrationDate.ToString("dd/MM/yyyy")}\n\n" + 
                   $"---------------------------------------------------------------\n";
        }

        public string ToStringAddress()
        {
            return $"{CityName}\n";
        }

        public string ToStringTicket()
        {
            return $"{CityName}\n";
        }
    }
}
