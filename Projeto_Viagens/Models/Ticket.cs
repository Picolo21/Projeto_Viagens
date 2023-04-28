namespace Projeto_Viagens_ADO.NET.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public Address? Origin { get; set; }
        public Address? Destination { get; set; }
        public Customer? Customer { get; set; }
        public DateTime Date { get; set; }
        public decimal TicketValue { get; set; }

        public string ToStringTicket()
        {
            return $"ID: {Id}\nOrigem: {Origin.ToStringTicket()}Destino: {Destination.ToStringTicket()}" +
                   $"Cliente: {Customer.CustomerName}\nData de Registro: {Date.ToString("dd/MM/yyyy")}\n" +
                   $"Valor: R$ {TicketValue.ToString("F2")}\n\n" +
                   $"------------------------------------------------------------------------------------\n";
        }

        public string ToStringPackage()
        {
            return $"Origem: {Origin.ToStringTicket()}Destino: {Destination.ToStringPackage()}";
        }
    }
}
