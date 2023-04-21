using Projeto_Viagens.Models;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_Viagens.Services
{
    public class TicketService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\Projeto_Viagens\Banco\Viagens.mdf;";
        readonly SqlConnection conn;

        public TicketService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public bool Insert(Ticket ticket)
        {
            bool status = false;
            try
            {
                string strInsert = "INSERT INTO Ticket (Origin, Destination, Client, Date, Value) VALUES (@Origin, @Destination, @Client, @Date, @Value); SELECT CAST(scope_identity() as int)";

                SqlCommand commandInsert = new SqlCommand(strInsert, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Origin", InsertAddress(ticket.Origin).Id));
                commandInsert.Parameters.Add(new SqlParameter("@Destination", InsertAddress(ticket.Destination).Id));
                commandInsert.Parameters.Add(new SqlParameter("@Client", InsertClient(ticket.Client).Id));
                commandInsert.Parameters.Add(new SqlParameter("@Date", ticket.Date));
                commandInsert.Parameters.Add(new SqlParameter("@Value", ticket.Value));

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

        public Client InsertClient(Client client)
        {
            string strInsert = "INSERT INTO Client (Name, Phone, RegistrationDate, Id_Address,) VALUES (@Name, @Phone, @RegistrationDate, @Id_Address); SELECT CAST(scope_identity() as int)";

            SqlCommand commandInsert = new SqlCommand(strInsert, conn);

            commandInsert.Parameters.Add(new SqlParameter("@Name", client.Name));
            commandInsert.Parameters.Add(new SqlParameter("@Phone", client.Phone));
            commandInsert.Parameters.Add(new SqlParameter("@RegistrationDate", client.RegistrationDate));
            commandInsert.Parameters.Add(new SqlParameter("@Id_Address", InsertAddress(client.Address).Id));

            var id = (int) commandInsert.ExecuteScalar();
            client.Id = id;

            return client;
        }

        public Address InsertAddress(Address address)
        {
            string strInsert = "INSERT INTO Address (Street, Number, Neighborhood, ZipCode, Complement, RegistrationDate, Id_City) VALUES (@Street, @Number, @Neighborhood, @ZipCode, @Complement, @RegistrationDate, @Id_City); SELECT CAST(scope_identity() as int)";

            SqlCommand commandInsert = new SqlCommand(strInsert, conn);

            commandInsert.Parameters.Add(new SqlParameter("@Street", address.Street));
            commandInsert.Parameters.Add(new SqlParameter("@Number", address.Number));
            commandInsert.Parameters.Add(new SqlParameter("@Neighborhood", address.Neighborhood));
            commandInsert.Parameters.Add(new SqlParameter("@ZipCode", address.ZipCode));
            commandInsert.Parameters.Add(new SqlParameter("@Complement", address.Complement));
            commandInsert.Parameters.Add(new SqlParameter("@RegistrationDate", address.RegistrationDate));
            commandInsert.Parameters.Add(new SqlParameter("@Id_City", InsertCity(address.City).Id));

            var id = (int) commandInsert.ExecuteScalar();
            address.Id = id;

            return address;
        }

        public City InsertCity(City city)
        {
            string strInsert = "INSERT INTO City (Description, RegistrationDate) VALUES (@Description, @RegistrationDate); SELECT CAST(scope_identity() as int)";

            SqlCommand commandInsert = new SqlCommand(strInsert, conn);

            commandInsert.Parameters.Add(new SqlParameter("@Name", city.Name));
            commandInsert.Parameters.Add(new SqlParameter("@Name", city.RegistrationDate));

            var id = (int)commandInsert.ExecuteScalar();
            city.Id = id;

            return city;
        }


        public List<Ticket> FindAll()
        {
            List<Ticket> tickets = new List<Ticket>();

            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT Id,");
            sb.Append(" Description,");
            sb.Append(" RegistrationDate,");
            sb.Append(" FROM City");

            SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                Ticket ticket = new Ticket();

                //ticket.Id = (int)dr["Id"];
                //ticket.Description = (string)dr["Description"];
                //ticket.RegistrationDate = (DateTime)dr["RegistrationDate"];

                tickets.Add(ticket);
            }
            return tickets;
        }
    }
}
