using Projeto_Viagens_ADO.NET.Models;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_Viagens_ADO.NET.Services
{
    public class PackageService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\Projeto_Viagens\Database\Viagens.mdf";
        readonly SqlConnection conn;

        public PackageService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public bool Insert(Package package, int idHotel, int idTicket, int idCustomer)
        {
            bool status = false;
            try
            {
                string strInsert = "INSERT INTO Package (Hotel, Ticket, RegistrationDate, PackageValue, Customer) VALUES (@Hotel, @Ticket, @RegistrationDate, @PackageValue, @Customer)";

                SqlCommand commandInsert = new SqlCommand(strInsert, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Hotel", idHotel));
                commandInsert.Parameters.Add(new SqlParameter("@Ticket", idTicket));
                commandInsert.Parameters.Add(new SqlParameter("@RegistrationDate", package.RegistrationDate));
                commandInsert.Parameters.Add(new SqlParameter("@PackageValue", package.PackageValue));
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

        public bool Update(Package package, int id)
        {
            bool status = false;
            try
            {
                string strUpdate = "UPDATE Package SET RegistrationDate = @RegistrationDate, PackageValue = @PackageValue WHERE Id = @Id";

                SqlCommand commandUpdate = new SqlCommand(strUpdate, conn);

                commandUpdate.Parameters.Add(new SqlParameter("@Id", id));
                commandUpdate.Parameters.Add(new SqlParameter("@RegistrationDate", package.RegistrationDate));
                commandUpdate.Parameters.Add(new SqlParameter("@PackageValue", package.PackageValue));

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
                string strDelete = $"DELETE FROM Package WHERE Id = @Id";

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

        public List<Package> FindAll()
        {
            List<Package> packages = new List<Package>();

            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT P.Id,");
            sb.Append(" P.RegistrationDate,");
            sb.Append(" P.PackageValue,");
            sb.Append(" H.HotelName,");
            sb.Append(" H.RegistrationDate AS RegistrationDateHotel,");
            sb.Append(" H.HotelValue,");
            sb.Append(" AH.Street AS StreetHotel,");
            sb.Append(" AH.Number AS NumberHotel,");
            sb.Append(" AH.Neighborhood AS NeighborhoodHotel,");
            sb.Append(" AH.PostalCode AS PostalCodeHotel,");
            sb.Append(" AH.Complement AS ComplementHotel,");
            sb.Append(" AH.RegistrationDate AS RegistrationDateHotel,");
            sb.Append(" CH.CityName AS CityNameHotel,");
            sb.Append(" CH.RegistrationDate AS RegistrationDateCityHotel,");
            sb.Append(" T.[Date],");
            sb.Append(" T.TicketValue,");
            sb.Append(" ATO.Street AS StreetOriginTicket,");
            sb.Append(" ATO.Number AS NumberOriginTicket,");
            sb.Append(" ATO.Neighborhood AS NeighborhoodOriginTicket,");
            sb.Append(" ATO.PostalCode AS PostalCodeOriginTicket,");
            sb.Append(" ATO.Complement AS ComplementOriginTicket,");
            sb.Append(" ATO.RegistrationDate AS RegistrationDateOriginTicket,");
            sb.Append(" CO.CityName AS CityNameOrigin,");
            sb.Append(" CO.RegistrationDate AS RegistrationDateCityOrigin,");
            sb.Append(" ATD.Street AS StreetDestinationTicket,");
            sb.Append(" ATD.Number AS NumberDestinationTicket,");
            sb.Append(" ATD.Neighborhood AS NeighborhoodDestinationTicket,");
            sb.Append(" ATD.PostalCode AS PostalCodeDestinationTicket,");
            sb.Append(" ATD.Complement AS ComplementDestinationTicket,");
            sb.Append(" ATD.RegistrationDate AS RegistrationDateDestinationTicket,");
            sb.Append(" CD.CityName AS CityNameDestination,");
            sb.Append(" CD.RegistrationDate AS RegistrationDateCityDestination,");
            sb.Append(" CT.CustomerName AS CustomerNameTicket,");
            sb.Append(" CT.Phone AS PhoneTicket,");
            sb.Append(" CT.RegistrationDate AS RegistrationDateTicket,");
            sb.Append(" ATC.Street AS StreetTicket,");
            sb.Append(" ATC.Number AS NumberTicket,");
            sb.Append(" ATC.Neighborhood AS NeighborhoodTicket,");
            sb.Append(" ATC.PostalCode AS PostalCodeTicket,");
            sb.Append(" ATC.Complement AS ComplementTicket,");
            sb.Append(" ATC.RegistrationDate AS RegistrationDateTicket,");
            sb.Append(" CC.CityName AS CityNameTicket,");
            sb.Append(" CC.RegistrationDate AS RegistrationDateCityTicket,");
            sb.Append(" C.CustomerName,");
            sb.Append(" C.Phone,");
            sb.Append(" C.RegistrationDate AS RegistrationDateCustomer,");
            sb.Append(" AC.Street AS StreetCustomer,");
            sb.Append(" AC.Number AS NumberCustomer,");
            sb.Append(" AC.Neighborhood AS NeighborhoodCustomer,");
            sb.Append(" AC.PostalCode AS PostalCodeCustomer,");
            sb.Append(" AC.Complement AS ComplementCustomer,");
            sb.Append(" AC.RegistrationDate AS RegistrationDateCustomer,");
            sb.Append(" Ci.CityName AS CityNameCustomer,");
            sb.Append(" Ci.RegistrationDate AS RegistrationDateCustomer");
            sb.Append(" FROM Package P, Hotel H, [Address] AH, City CH,");
            sb.Append(" Ticket T, [Address] ATO, City CO, [Address] ATD, City CD, Customer CT, [Address] ATC, City CC,");
            sb.Append(" Customer C, [Address] AC, City Ci");
            sb.Append(" WHERE P.Hotel = H.Id AND H.IdAddress = AH.Id AND AH.IdCity = CH.Id");
            sb.Append(" AND P.Customer = C.Id AND C.IdAddress = AC.Id AND AC.IdCity = Ci.Id");
            sb.Append(" AND P.Ticket = T.Id AND T.Origin = ATO.Id AND T.Destination = ATD.Id AND ATO.IdCity = CO.Id AND ATD.IdCity = CD.Id AND T.Customer = CT.Id AND CT.IdAddress = ATC.Id AND ATC.IdCity = CC.Id");

            SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                Package package = new Package();

                package.Id = (int)dr["Id"];
                package.RegistrationDate = (DateTime)dr["RegistrationDate"];
                package.PackageValue = (decimal)dr["PackageValue"];
                package.Hotel = new Hotel
                {
                    HotelName = (string)dr["HotelName"],
                    RegistrationDate = (DateTime)dr["RegistrationDateHotel"],
                    HotelValue = (decimal)dr["HotelValue"],
                    Address = new Address
                    {
                        Street = (string)dr["StreetHotel"],
                        Number = (int)dr["NumberHotel"],
                        Neighborhood = (string)dr["NeighborhoodHotel"],
                        PostalCode = (string)dr["PostalCodeHotel"],
                        Complement = (string)dr["ComplementHotel"],
                        RegistrationDate = (DateTime)dr["RegistrationDateHotel"],
                        City = new City
                        {
                            CityName = (string)dr["CityNameHotel"],
                            RegistrationDate = (DateTime)dr["RegistrationDateCityHotel"]
                        }
                    }
                };
                package.Ticket = new Ticket
                {
                    Origin = new Address
                    {
                        Street = (string)dr["StreetOriginTicket"],
                        Number = (int)dr["NumberOriginTicket"],
                        Neighborhood = (string)dr["NeighborhoodOriginTicket"],
                        PostalCode = (string)dr["PostalCodeOriginTicket"],
                        Complement = (string)dr["ComplementOriginTicket"],
                        RegistrationDate = (DateTime)dr["RegistrationDateOriginTicket"],
                        City = new City
                        {
                            CityName = (string)dr["CityNameOrigin"],
                            RegistrationDate = (DateTime)dr["RegistrationDateCityOrigin"]
                        }
                    },
                    Destination = new Address
                    {
                        Street = (string)dr["StreetDestinationTicket"],
                        Number = (int)dr["NumberDestinationTicket"],
                        Neighborhood = (string)dr["NeighborhoodDestinationTicket"],
                        PostalCode = (string)dr["PostalCodeDestinationTicket"],
                        Complement = (string)dr["ComplementDestinationTicket"],
                        RegistrationDate = (DateTime)dr["RegistrationDateDestinationTicket"],
                        City = new City
                        {
                            CityName = (string)dr["CityNameDestination"],
                            RegistrationDate = (DateTime)dr["RegistrationDateCityDestination"]
                        }
                    },
                    Customer = new Customer
                    {
                        CustomerName = (string)dr["CustomerNameTicket"],
                        Phone = (string)dr["PhoneTicket"],
                        RegistrationDate = (DateTime)dr["RegistrationDateTicket"],
                        Address = new Address
                        {
                            Street = (string)dr["StreetTicket"],
                            Number = (int)dr["NumberTicket"],
                            Neighborhood = (string)dr["NeighborhoodTicket"],
                            PostalCode = (string)dr["PostalCodeTicket"],
                            Complement = (string)dr["ComplementTicket"],
                            RegistrationDate = (DateTime)dr["RegistrationDateTicket"],
                            City = new City
                            {
                                CityName = (string)dr["CityNameTicket"],
                                RegistrationDate = (DateTime)dr["RegistrationDateCityTicket"]
                            }
                        }
                    },
                    Date = (DateTime)dr["Date"],
                    TicketValue = (decimal)dr["TicketValue"]
                };
                package.Customer = new Customer
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

                packages.Add(package);
            };
            return packages;
        }
    }
}

