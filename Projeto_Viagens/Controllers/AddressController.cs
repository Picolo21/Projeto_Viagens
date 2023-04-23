using Projeto_Viagens.Models;
using Projeto_Viagens.Services;

namespace Projeto_Viagens.Controllers
{
    public class AddressController
    {
        public bool Insert(Address address, int id)
        {
            return new AddressServive().Insert(address, id);
        }

        public bool Insert(Address address, City city)
        {
            return new AddressServive().Insert(address, city);
        }

        public bool Update(Address address, int id)
        {
            return new AddressServive().Update(address, id);
        }

        public bool Delete(int id)
        {
            return new AddressServive().Delete(id);
        }

        public List<Address> FindAll()
        {
            return new AddressServive().FindAll();
        }
    }
}
