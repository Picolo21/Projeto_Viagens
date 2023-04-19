using Projeto_Viagens.Models;
using Projeto_Viagens.Services;

namespace Projeto_Viagens.Controllers
{
    public class TicketController
    {
        public bool Insert(Ticket ticket)
        {
            var city = new TicketService().InsertCity(ticket.Client.Address.City);
            ticket.Client.Address.City = city;
            var address = new TicketService().InsertAddress(ticket.Client.Address);
            ticket.Client.Address = address;
            var client = new TicketService().InsertClient(ticket.Client);
            ticket.Client = client;
            return new TicketService().Insert(ticket);
        }
    }
}
