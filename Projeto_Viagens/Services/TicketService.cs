using Projeto_Viagens.Models;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_Viagens.Services
{
    public class TicketService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\Projeto_Viagens\Database\Viagens.mdf";
        readonly SqlConnection conn;

        public TicketService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public bool Insert(Ticket ticket, int idOrigin, int idDestination, int idCustomer)
        {
            bool status = false;
            try
            {
                string strInsert = "INSERT INTO Ticket (Date, TicketValue, Origin, Destination, Customer) VALUES (@Date, @TicketValue, @Origin, @Destination, @Customer)";

                SqlCommand commandInsert = new SqlCommand(strInsert, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Date", ticket.Date));
                commandInsert.Parameters.Add(new SqlParameter("@TicketValue", ticket.TicketValue));
                commandInsert.Parameters.Add(new SqlParameter("@Origin", idOrigin));
                commandInsert.Parameters.Add(new SqlParameter("@Destination", idDestination));
                commandInsert.Parameters.Add(new SqlParameter("@Customer", idCustomer));

                commandInsert.ExecuteNonQuery();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        public bool Update(Ticket ticket, int id)
        {
            bool status = false;
            try
            {
                string strUpdate = "UPDATE Ticket SET Date = @Date, TicketValue = @TicketValue WHERE Id = @Id";

                SqlCommand commandUpdate = new SqlCommand(strUpdate, conn);

                commandUpdate.Parameters.Add(new SqlParameter("@Id", id));
                commandUpdate.Parameters.Add(new SqlParameter("@Date", ticket.Date));
                commandUpdate.Parameters.Add(new SqlParameter("@TicketValue", ticket.TicketValue));

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
                string strDelete = $"DELETE FROM Ticket WHERE Id = @Id";

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

        public List<Ticket> FindAll()
        {
            List<Ticket> tickets = new List<Ticket>();

            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT T.Id,");
            sb.Append(" T.[Date],");
            sb.Append(" T.TicketValue,");
            sb.Append(" AO.Street AS StreetOrigin,");
            sb.Append(" AO.Number AS NumberOrigin,");
            sb.Append(" AO.Neighborhood AS NeighborhoodOrigin,");
            sb.Append(" AO.PostalCode AS PostalCodeOrigin,");
            sb.Append(" AO.Complement AS ComplementOrigin,");
            sb.Append(" AO.RegistrationDate AS RegistrationDateOrigin,");
            sb.Append(" CiO.CityName AS CityNameOrigin,");
            sb.Append(" CiO.RegistrationDate AS RegistrationDateCityOrigin,");
            sb.Append(" AD.Street AS StreetDestination,");
            sb.Append(" AD.Number AS NumberDestination,");
            sb.Append(" AD.Neighborhood AS NeighborhoodDestination,");
            sb.Append(" AD.PostalCode AS PostalCodeDestination,");
            sb.Append(" AD.Complement AS ComplementDestination,");
            sb.Append(" AD.RegistrationDate AS RegistrationDateDestination,");
            sb.Append(" CiD.CityName AS CityNameDestination,");
            sb.Append(" CiD.RegistrationDate AS RegistrationDateCityDestination,");
            sb.Append(" C.CustomerName,");
            sb.Append(" C.Phone,");
            sb.Append(" C.RegistrationDate AS RegistrationDateCustomer,");
            sb.Append(" A.Street AS StreetCustomer,");
            sb.Append(" A.Number AS NumberCustomer,");
            sb.Append(" A.Neighborhood AS NeighborhoodCustomer,");
            sb.Append(" A.PostalCode AS PostalCodeCustomer,");
            sb.Append(" A.Complement AS ComplementCustomer,");
            sb.Append(" A.RegistrationDate AS RegistrationDateCustomer,");
            sb.Append(" Ci.CityName AS CityNameCustomer,");
            sb.Append(" Ci.RegistrationDate AS RegistrationDateCustomer");
            sb.Append(" FROM Ticket T, [Address] AO, [Address] AD, [Address] A,");
            sb.Append(" Customer C, City Ci, City CiO, City CiD");
            sb.Append(" WHERE T.Origin = AO.Id AND AO.IdCity = CiO.Id");
            sb.Append(" AND T.Destination = AD.Id AND AD.IdCity = CiD.Id");
            sb.Append(" AND T.Customer = C.Id AND C.IdAddress = A.Id AND A.IdCity = Ci.Id");

            SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                Ticket ticket = new Ticket();

                ticket.Id = (int)dr["Id"];
                ticket.Date = (DateTime)dr["Date"];
                ticket.TicketValue = (decimal)dr["TicketValue"];
                ticket.Origin = new Address
                {
                    Street = (string)dr["StreetOrigin"],
                    Number = (int)dr["NumberOrigin"],
                    Neighborhood = (string)dr["NeighborhoodOrigin"],
                    PostalCode = (string)dr["PostalCodeOrigin"],
                    Complement = (string)dr["ComplementOrigin"],
                    RegistrationDate = (DateTime)dr["RegistrationDateOrigin"],
                    City = new City
                    {
                        CityName = (string)dr["CityNameOrigin"],
                        RegistrationDate = (DateTime)dr["RegistrationDateCityOrigin"]
                    }
                };
                ticket.Destination = new Address
                {
                    Street = (string)dr["StreetDestination"],
                    Number = (int)dr["NumberDestination"],
                    Neighborhood = (string)dr["NeighborhoodDestination"],
                    PostalCode = (string)dr["PostalCodeDestination"],
                    Complement = (string)dr["ComplementDestination"],
                    RegistrationDate = (DateTime)dr["RegistrationDateDestination"],
                    City = new City
                    {
                        CityName = (string)dr["CityNameDestination"],
                        RegistrationDate = (DateTime)dr["RegistrationDateCityDestination"]
                    }
                };
                ticket.Customer = new Customer
                {
                    CustomerName = (string)dr["CustomerName"],
                    Phone = (string)dr["Phone"],
                    RegistrationDate = (DateTime)dr["RegistrationDateCustomer"],
                    Address = new Address
                    {
                        Street = (string)dr["StreetCustomer"],
                        Number = (int)dr["NumberCustomer"],
                        Neighborhood = (string)dr["NeighborhoodCustomer"],
                        PostalCode = (string)dr["PostalCodeCustomer"],
                        Complement = (string)dr["ComplementCustomer"],
                        RegistrationDate = (DateTime)dr["RegistrationDateCustomer"],
                        City = new City
                        {
                            CityName = (string)dr["CityNameCustomer"],
                            RegistrationDate = (DateTime)dr["RegistrationDateCustomer"]
                        }
                    }
                };

                tickets.Add(ticket);
            };
            return tickets;
        }
    }
}
