using Projeto_Viagens.Models;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_Viagens.Services
{
    public class AddressServive
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\Projeto_Viagens\Database\Viagens.mdf";
        readonly SqlConnection conn;

        public AddressServive()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public bool Insert(Address address, int id)
        {
            bool status = false;
            try
            {
                string strInsert = "INSERT INTO Address (Street, Number, Neighborhood, PostalCode, Complement, RegistrationDate, IdCity) VALUES (@Street, @Number, @Neighborhood, @PostalCode, @Complement, @RegistrationDate, @IdCity)";

                SqlCommand commandInsert = new SqlCommand(strInsert, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Street", address.Street));
                commandInsert.Parameters.Add(new SqlParameter("@Number", address.Number));
                commandInsert.Parameters.Add(new SqlParameter("@Neighborhood", address.Neighborhood));
                commandInsert.Parameters.Add(new SqlParameter("@PostalCode", address.PostalCode));
                commandInsert.Parameters.Add(new SqlParameter("@Complement", address.Complement));
                commandInsert.Parameters.Add(new SqlParameter("@RegistrationDate", address.RegistrationDate));
                commandInsert.Parameters.Add(new SqlParameter("@IdCity", id));

                commandInsert.ExecuteNonQuery();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        public bool Update(Address address, int id)
        {
            bool status = false;
            try
            {
                string strUpdate = "UPDATE Address SET Street = @Street, Number = @Number, Neighborhood = @Neighborhood, PostalCode = @PostalCode, Complement = @Complement, RegistrationDate = @RegistrationDate WHERE Id = @Id";

                SqlCommand commandUpdate = new SqlCommand(strUpdate, conn);

                commandUpdate.Parameters.Add(new SqlParameter("@Id", id));
                commandUpdate.Parameters.Add(new SqlParameter("@Street", address.Street));
                commandUpdate.Parameters.Add(new SqlParameter("@Number", address.Number));
                commandUpdate.Parameters.Add(new SqlParameter("@Neighborhood", address.Neighborhood));
                commandUpdate.Parameters.Add(new SqlParameter("@PostalCode", address.PostalCode));
                commandUpdate.Parameters.Add(new SqlParameter("@Complement", address.Complement));
                commandUpdate.Parameters.Add(new SqlParameter("@RegistrationDate", address.RegistrationDate));

                commandUpdate.ExecuteNonQuery();
                status = true;
            }
            catch (Exception)
            {
                status= false;
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;
            try
            {
                string strDelete = $"DELETE FROM Address WHERE Id = @Id";

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

        public List<Address> FindAll()
        {
            List<Address> addresses = new List<Address>();

            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT A.Id,");
            sb.Append(" A.Street,");
            sb.Append(" A.Number,");
            sb.Append(" A.Neighborhood,");
            sb.Append(" A.PostalCode,");
            sb.Append(" A.Complement,");
            sb.Append(" A.RegistrationDate,");
            sb.Append(" C.[CityName],");
            sb.Append(" C.RegistrationDate AS RegistrationDateCity");
            sb.Append(" FROM [Address] A, City C");
            sb.Append(" WHERE A.IdCity = C.Id");

            SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                Address address = new Address();

                address.Id = (int)dr["Id"];
                address.Street = (string)dr["Street"];
                address.Number = (int)dr["Number"];
                address.Neighborhood = (string)dr["Neighborhood"];
                address.PostalCode = (string)dr["PostalCode"];
                address.Complement = (string)dr["Complement"];
                address.RegistrationDate = (DateTime)dr["RegistrationDate"];
                address.City = new City
                {
                    CityName = (string)dr["CityName"],
                    RegistrationDate = (DateTime)dr["RegistrationDateCity"]
                };

                addresses.Add(address);
            }
            return addresses;
        }
    }
}
