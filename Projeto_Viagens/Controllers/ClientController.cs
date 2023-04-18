using Projeto_Viagens.Models;
using Projeto_Viagens.Services;

namespace Projeto_Viagens.Controllers
{
    public class ClientController
    {
        public bool Insert(Client client)
        {
            return new ClientService().Insert(client);
        }

        public List<Client> FindAll()
        {
            return new ClientService().FindAll();
        }
    }
}
