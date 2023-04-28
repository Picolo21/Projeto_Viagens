using Projeto_Viagens_ADO.NET.Models;
using Projeto_Viagens_ADO.NET.Services;

namespace Projeto_Viagens_ADO.NET.Controllers
{
    public class AddressController
    {
        public bool Insert(Address address, int id)
        {
            return new AddressServive().Insert(address, id);
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
