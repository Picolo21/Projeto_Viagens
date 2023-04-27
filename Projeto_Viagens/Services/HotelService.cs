using Projeto_Viagens.Models;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_Viagens.Services
{
    public class HotelService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\Projeto_Viagens\Database\Viagens.mdf";
        readonly SqlConnection conn;

        public HotelService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public bool Insert(Hotel hotel, int id)
        {
            bool status = false;
            try
            {
                string strInsert = "INSERT INTO Hotel (HotelName, RegistrationDate, HotelValue, IdAddress) VALUES (@HotelName, @RegistrationDate, @Value, @IdAddress)";

                SqlCommand commandInsert = new SqlCommand(strInsert, conn);

                commandInsert.Parameters.Add(new SqlParameter("@HotelName", hotel.HotelName));
                commandInsert.Parameters.Add(new SqlParameter("@RegistrationDate", hotel.RegistrationDate));
                commandInsert.Parameters.Add(new SqlParameter("@Value", hotel.HotelValue));
                commandInsert.Parameters.Add(new SqlParameter("@IdAddress", id));

                commandInsert.ExecuteNonQuery();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        public bool Update(Hotel hotel, int id)
        {
            bool status = false;
            try
            {
                string strUpdate = "UPDATE Hotel SET HotelName = @HotelName, RegistrationDate = @RegistrationDate, HotelValue = @Value WHERE Id = @Id";

                SqlCommand commandUpdate = new SqlCommand(strUpdate, conn);

                commandUpdate.Parameters.Add(new SqlParameter("@Id", id));
                commandUpdate.Parameters.Add(new SqlParameter("@HotelName", hotel.HotelName));
                commandUpdate.Parameters.Add(new SqlParameter("@RegistrationDate", hotel.RegistrationDate));
                commandUpdate.Parameters.Add(new SqlParameter("@Value", hotel.HotelValue));

                commandUpdate.ExecuteNonQuery();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;
            try
            {
                string strDelete = $"DELETE FROM Hotel WHERE Id = @Id";

                SqlCommand commandDelete = new SqlCommand(strDelete, conn);

                commandDelete.Parameters.Add(new SqlParameter("@Id", id));

                commandDelete.ExecuteNonQuery();

                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        public List<Hotel> FindAll()
        {
            List<Hotel> hotels = new List<Hotel>();

            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT H.Id,");
            sb.Append(" H.[HotelName],");
            sb.Append(" H.RegistrationDate,");
            sb.Append(" H.HotelValue,");
            sb.Append(" A.Street,");
            sb.Append(" A.Number,");
            sb.Append(" A.Neighborhood,");
            sb.Append(" A.PostalCode,");
            sb.Append(" A.Complement,");
            sb.Append(" A.RegistrationDate AS RegistrationDateAddress,");
            sb.Append(" Ci.[CityName],");
            sb.Append(" Ci.RegistrationDate AS RegistrationDateCity");
            sb.Append(" FROM Hotel H, [Address] A, City Ci");
            sb.Append(" WHERE H.IdAddress = A.Id AND A.IdCity = Ci.Id");

            SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                Hotel hotel = new Hotel();

                hotel.Id = (int)dr["Id"];
                hotel.HotelName = (string)dr["HotelName"];
                hotel.RegistrationDate = (DateTime)dr["RegistrationDate"];
                hotel.HotelValue = (decimal)dr["HotelValue"];
                hotel.Address = new Address
                {
                    Street = (string)dr["Street"],
                    Number = (int)dr["Number"],
                    Neighborhood = (string)dr["Neighborhood"],
                    PostalCode = (string)dr["PostalCode"],
                    Complement = (string)dr["Complement"],
                    RegistrationDate = (DateTime)dr["RegistrationDate"],
                    City = new City
                    {
                        CityName = (string)dr["CityName"],
                        RegistrationDate = (DateTime)dr["RegistrationDate"]
                    }
                };
                hotels.Add(hotel);
            };
            return hotels;
        }
    }
}
