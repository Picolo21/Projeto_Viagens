using Projeto_Viagens_ADO.NET.Models;
using Projeto_Viagens_ADO.NET.Services;

namespace Projeto_Viagens_ADO.NET.Controllers
{
    public class CityController
    {
        public bool Insert(City city)
        {
            return new CityService().Insert(city);
        }

        public bool Update(City city, int id)
        {
            return new CityService().Update(city, id);
        }

        public bool Delete(int id)
        {
            return new CityService().Delete(id);
        }

        public List<City> FindAll()
        {
            return new CityService().FindAll();
        }
    }
}
