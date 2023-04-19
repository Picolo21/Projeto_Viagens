using Projeto_Viagens.Models;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_Viagens.Services
{
    public class CityService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\Projeto_Viagens\Banco\Viagens.mdf;";
        readonly SqlConnection conn;

        public CityService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public bool Insert(City city)
        {
            bool status = false;
            try
            {
                string strInsert = "INSERT INTO City (Description, RegistrationDate) VALUES (@Description, @RegistrationDate)";

                SqlCommand commandInsert = new SqlCommand(strInsert, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Description", city.Description));
                commandInsert.Parameters.Add(new SqlParameter("@RegistrationDate", city.RegistrationDate));

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

        public List<City> FindAll()
        {
            List<City> cities = new List<City>();

            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT Id,");
            sb.Append(" Description,");
            sb.Append(" RegistrationDate");
            sb.Append(" FROM City");

            SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                City city = new City();

                city.Id = (int) dr["Id"];
                city.Description = (string) dr["Description"];
                city.RegistrationDate = (DateTime) dr["RegistrationDate"];

                cities.Add(city);
            }
            return cities;
        }
    }
}
