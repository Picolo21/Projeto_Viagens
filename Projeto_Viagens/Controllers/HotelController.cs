using Projeto_Viagens.Models;
using Projeto_Viagens.Services;

namespace Projeto_Viagens.Controllers
{
    public class HotelController
    {
        public bool Insert(Hotel hotel)
        {
            return new HotelService().Insert(hotel);
        }

        public List<Hotel> FindAll()
        {
            return new HotelService().FindAll();
        }
    }
}
