using Projeto_Viagens.Models;
using System.Data.SqlClient;
using System.IO;
using System.Reflection.Emit;
using System.Text;

namespace Projeto_Viagens.Services
{
    public class HotelService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\Projeto_Viagens\Banco\Viagens.mdf;";
        readonly SqlConnection conn;

        public HotelService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public bool Insert(Hotel hotel)
        {
            bool status = false;
            try
            {
                string strInsert = "INSERT INTO Hotel (Name, RegistrationDate, Value) VALUES (@Name, @RegistrationDate, @Value)";

                SqlCommand commandInsert = new SqlCommand(strInsert, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Name", hotel.Name));
                commandInsert.Parameters.Add(new SqlParameter("@RegistrationDate", hotel.RegistrationDate));
                commandInsert.Parameters.Add(new SqlParameter("@Value", hotel.Value));

                commandInsert.ExecuteNonQuery();
                status = true;
            }
            catch (Exception)
            {
                status = false;
                throw;
            }
            return status;
        }

        public List<Hotel> FindAll()
        {
            List<Hotel> hotels = new List<Hotel>();

            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT H.Id,");
            sb.Append(" H.Name,");
            sb.Append(" H.RegistrationDate,");
            sb.Append(" H.Value,");
            sb.Append(" A.Street,");
            sb.Append(" A.Number,");
            sb.Append(" A.Neighborhood,");
            sb.Append(" A.ZipCode,");
            sb.Append(" A.Complement,");
            sb.Append(" A.RegistrationDate AS AddresRegistrationDate,");
            sb.Append(" C.Description,");
            sb.Append(" C.RegistrationDate AS CityRegistrationDate,");
            sb.Append(" FROM Hotel H, Address A, City C");
            sb.Append(" WHERE A.Id = H.Id_Address AND A.Id_City = C.Id");

            SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                Hotel hotel = new Hotel();

                hotel.Id = (int) dr["Id"];
                hotel.Name = (string) dr["Name"];
                hotel.RegistrationDate = (DateTime) dr["RegistrationDate"];
                hotel.Value = (double) dr["Value"];
                hotel.Address = new Address()
                {
                    Street = (string) dr["Street"],
                    Number = (int) dr["Street"],
                    Neighborhood = (string) dr["Street"],
                    ZipCode = (string) dr["Street"],
                    Complement = (string) dr["Street"],
                    RegistrationDate = (DateTime) dr["Street"]
                };
                hotel.Address.City = new City()
                {
                    Description = (string) dr["Description"],
                    RegistrationDate = (DateTime) dr["CityRegistrationDate"]
                };

                hotels.Add(hotel);
            }
            return hotels;
        }
    }
}
