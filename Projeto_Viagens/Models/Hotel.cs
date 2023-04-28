namespace Projeto_Viagens_ADO.NET.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string? HotelName { get; set; }
        public Address? Address { get; set; }
        public DateTime RegistrationDate { get; set; }
        public decimal HotelValue { get; set; }

        public string ToStringHotel()
        {
            return $"ID: {Id}\nNome do Hotel: {HotelName}\n" +
                   $"{Address.ToStringHotel()}" +
                   $"Data de Registro: {RegistrationDate.ToString("dd/MM/yyyy")}\n" +
                   $"Valor: R$ {HotelValue.ToString("F2")}\n\n" + 
                   $"------------------------------------\n";
        }

        public string ToStringPackage()
        {
            return $"{HotelName}";
        }
    }
}
