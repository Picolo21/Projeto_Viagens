using Projeto_Viagens.Models;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_Viagens.Services
{
    public class ClientService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\Projeto_Viagens\Database\Viagens.mdf";
        readonly SqlConnection conn;

        public ClientService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public bool Insert(Client client, int id)
        {
            bool status = false;
            try
            {
                string strInsert = "INSERT INTO Client (ClientName, Phone, RegistrationDate, IdAddress) VALUES (@Name, @Phone, @RegistrationDate, @IdAddress)";

                SqlCommand commandInsert = new SqlCommand(strInsert, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Name", client.ClientName));
                commandInsert.Parameters.Add(new SqlParameter("@Phone", client.Phone));
                commandInsert.Parameters.Add(new SqlParameter("@RegistrationDate", client.RegistrationDate));
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

        public bool Update(Client client, int id)
        {
            bool status = false;
            try
            {
                string strUpdate = "UPDATE Client SET ClientName = @Name, Phone = @Phone, RegistrationDate = @RegistrationDate WHERE Id = @Id";

                SqlCommand commandUpdate = new SqlCommand(strUpdate, conn);

                commandUpdate.Parameters.Add(new SqlParameter("@Id", id));
                commandUpdate.Parameters.Add(new SqlParameter("@Name", client.ClientName));
                commandUpdate.Parameters.Add(new SqlParameter("@Phone", client.Phone));
                commandUpdate.Parameters.Add(new SqlParameter("@RegistrationDate", client.RegistrationDate));

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
                string strDelete = $"DELETE FROM Client WHERE Id = @Id";

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

        public List<Client> FindAll()
        {
            List<Client> clients = new List<Client>();

            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT Cl.Id,");
            sb.Append(" Cl.[ClientName],");
            sb.Append(" Cl.Phone,");
            sb.Append(" Cl.RegistrationDate,");
            sb.Append(" A.Street,");
            sb.Append(" A.Number,");
            sb.Append(" A.Neighborhood,");
            sb.Append(" A.PostalCode,");
            sb.Append(" A.Complement,");
            sb.Append(" A.RegistrationDate AS RegistrationDateAddress,");
            sb.Append(" Ci.[CityName],");
            sb.Append(" Ci.RegistrationDate AS RegistrationDateCity");
            sb.Append(" FROM Client Cl, [Address] A, City Ci");
            sb.Append(" WHERE Cl.IdAddress = A.Id AND A.IdCity = Ci.Id");

            SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                Client client = new Client();

                client.Id = (int)dr["Id"];
                client.ClientName = (string)dr["ClientName"];
                client.Phone = (string)dr["Phone"];
                client.RegistrationDate = (DateTime)dr["RegistrationDate"];
                client.Address = new Address
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
                clients.Add(client);
            };
            return clients;
        }
    }
}
