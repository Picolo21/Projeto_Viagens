namespace Projeto_Viagens.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime RegistrationDate { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}\nDescrição: {Description}\nData de Registro: {RegistrationDate.ToString("dd/MM/yyyy")}";
        }
    }
}
