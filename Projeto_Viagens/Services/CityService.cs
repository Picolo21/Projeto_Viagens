using Projeto_Viagens.Models;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_Viagens.Services
{
    public class CityService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\Projeto_Viagens\Database\Viagens.mdf";
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
                string strInsert = "INSERT INTO City (Name, RegistrationDate) VALUES (@Name, @RegistrationDate)";

                SqlCommand commandInsert = new SqlCommand(strInsert, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Name", city.Name));
                commandInsert.Parameters.Add(new SqlParameter("@RegistrationDate", city.RegistrationDate));

                commandInsert.ExecuteNonQuery();
                status = true;
            }
            catch (SqlException e)
            {
                do
                {
                    Console.Clear();
                    status = false;
                    Console.WriteLine(e.Message + "\n");
                    Console.WriteLine("Aperte ENTER para voltar ao Menu de Inserir");
                } while (Console.ReadKey().Key != ConsoleKey.Enter);

            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        public bool Update(City city, int id)
        {
            bool status = false;
            try
            {
                string strUpdate = "UPDATE City SET Name = @Name, RegistrationDate = @RegistrationDate WHERE Id = @Id";

                SqlCommand commandUpdate = new SqlCommand(strUpdate, conn);

                commandUpdate.Parameters.Add(new SqlParameter("@Id", id));
                commandUpdate.Parameters.Add(new SqlParameter("@Name", city.Name));
                commandUpdate.Parameters.Add(new SqlParameter("@RegistrationDate", city.RegistrationDate));

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
                string strDelete = $"DELETE FROM City WHERE Id = @Id";

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

        public List<City> FindAll()
        {
            List<City> cities = new List<City>();

            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT Id,");
            sb.Append(" Name,");
            sb.Append(" RegistrationDate");
            sb.Append(" FROM City");

            SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                City city = new City();

                city.Id = (int)dr["Id"];
                city.Name = (string)dr["Name"];
                city.RegistrationDate = (DateTime)dr["RegistrationDate"];

                cities.Add(city);
            }
            return cities;
        }
    }
}
