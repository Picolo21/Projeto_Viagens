using Projeto_Viagens.Models;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_Viagens.Services
{
    public class ClientService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\Projeto_Viagens\Banco\Viagens.mdf;";
        readonly SqlConnection conn;

        public ClientService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public bool Insert(Client client)
        {
            bool status = false;
            try
            {
                string strInsert = "INSERT INTO Client (Name, Phone, RegistrationDate, Id_Address) VALUES (@Name, @Phone, @RegistrationDate, @Id_Address); SELECT CAST(scope_identity() as int)";

                SqlCommand commandInsert = new SqlCommand(strInsert, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Name", client.Name));
                commandInsert.Parameters.Add(new SqlParameter("@Phone", client.Phone));
                commandInsert.Parameters.Add(new SqlParameter("@RegistrationDate", client.RegistrationDate));
                commandInsert.Parameters.Add(new SqlParameter("@Id_Address", client.Address));

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

        public List<Client> FindAll()
        {
            List<Client> clients = new List<Client>();

            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT Cl.Id,");
            sb.Append(" Cl.[Name],");
            sb.Append(" Cl.Phone,");
            sb.Append(" Cl.RegistrationDate,");
            sb.Append(" A.Street,");
            sb.Append(" A.Number,");
            sb.Append(" A.Neighborhood,");
            sb.Append(" A.ZipCode,");
            sb.Append(" A.Complement,");
            sb.Append(" A.RegistrationDate AS AddressRegistrationDate,");
            sb.Append(" Ci.[Description]");
            sb.Append(" FROM Client Cl, [Address] A, City Ci");
            sb.Append(" WHERE Cl.Id_Address = A.Id AND A.Id_City = Ci.Id");

            SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                Client client = new Client();

                client.Id = (int) dr["Id"];
                client.Name = (string) dr["Name"];
                client.Phone = (string) dr["Phone"];
                client.RegistrationDate = (DateTime) dr["RegistrationDate"];
                client.Address = new Address()
                {
                    Street = (string)dr["Street"],
                    Number = (int)dr["Number"],
                    Neighborhood = (string)dr["Neighborhood"],
                    ZipCode = (string)dr["ZipCode"],
                    Complement = (string)dr["Complement"],
                    RegistrationDate = (DateTime)dr["AddressRegistrationDate"]
                };
                client.Address.City = new City()
                {
                    Name = (string)dr["Description"]
                };

                clients.Add(client);
            }
            return clients;
        }
    }
}
