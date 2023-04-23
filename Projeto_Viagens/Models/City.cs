namespace Projeto_Viagens.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }

        public string ToStringCity()
        {
            return $"ID: {Id}\nNome: {Name}\nData de Registro: {RegistrationDate.ToString("dd/MM/yyyy")}\n\n" + 
                   $"---------------------------------------------------------------\n";
        }

        public string ToStringAddress()
        {
            return $"{Name}\n";
        }
    }
}
