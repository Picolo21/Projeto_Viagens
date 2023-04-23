using Projeto_Viagens.Models;
using Projeto_Viagens.Services;

namespace Projeto_Viagens.Controllers
{
    public class ClientController
    {
        public bool Insert(Client client, int id)
        {
            return new ClientService().Insert(client, id);
        }

        public bool Update(Client client, int id)
        {
            return new ClientService().Update(client, id);
        }

        public bool Delete(int id)
        {
            return new ClientService().Delete(id);
        }

        public List<Client> FindAll()
        {
            return new ClientService().FindAll();
        }
    }
}
