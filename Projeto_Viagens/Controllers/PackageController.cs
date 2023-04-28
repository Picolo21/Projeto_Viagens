using Projeto_Viagens_ADO.NET.Models;
using Projeto_Viagens_ADO.NET.Services;

namespace Projeto_Viagens_ADO.NET.Controllers
{
    public class PackageController
    {
        public bool Insert(Package package, int idHotel, int idTicket, int idCustomer)
        {
            return new PackageService().Insert(package, idHotel, idTicket,idCustomer);
        }

        public bool Update(Package package, int id)
        {
            return new PackageService().Update(package, id);
        }

        public bool Delete(int id)
        {
            return new PackageService().Delete(id);
        }

        public List<Package> FindAll()
        {
            return new PackageService().FindAll();
        }
    }
}
