using Projeto_Viagens_ADO.NET.Models;
using Projeto_Viagens_ADO.NET.Services;

namespace Projeto_Viagens_ADO.NET.Controllers
{
    public class TicketController
    {
        public bool Insert(Ticket ticket, int idOrigin, int idDestination, int idCustomer)
        {
            return new TicketService().Insert(ticket, idOrigin, idDestination, idCustomer);
        }

        public bool Update(Ticket ticket, int id)
        {
            return new TicketService().Update(ticket, id);
        }

        public bool Delete(int id)
        {
            return new TicketService().Delete(id);
        }

        public List<Ticket> FindAll()
        {
            return new TicketService().FindAll();
        }
    }
}
