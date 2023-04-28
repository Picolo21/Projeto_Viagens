using Projeto_Viagens_ADO.NET.Models;
using Projeto_Viagens_ADO.NET.Services;

namespace Projeto_Viagens_ADO.NET.Controllers
{
    public class HotelController
    {
        public bool Insert(Hotel hotel, int id)
        {
            return new HotelService().Insert(hotel, id);
        }

        public bool Update(Hotel hotel, int id)
        {
            return new HotelService().Update(hotel, id);
        }

        public bool Delete(int id)
        {
            return new HotelService().Delete(id);
        }

        public List<Hotel> FindAll()
        {
            return new HotelService().FindAll();
        }
    }
}
