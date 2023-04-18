using Projeto_Viagens.Models;
using Projeto_Viagens.Services;

namespace Projeto_Viagens.Controllers
{
    public class AddressController
    {
        public bool Insert(Address address)
        {
            return new AddressService().Insert(address);
        }

        public List<Address> FindAll()
        {
            return new AddressService().FindAll();
        }
    }
}
