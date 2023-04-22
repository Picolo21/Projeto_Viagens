using Projeto_Viagens.Models;
using Projeto_Viagens.Services;

namespace Projeto_Viagens.Controllers
{
    public class CityController
    {
        public bool Insert(City city)
        {
            return new CityService().Insert(city);
        }

        public List<City> FindAll()
        {
            return new CityService().FindAll();
        }
    }
}
