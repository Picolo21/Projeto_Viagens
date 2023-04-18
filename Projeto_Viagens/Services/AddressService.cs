using Projeto_Viagens.Models;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_Viagens.Services
{
    public class AddressService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\Projeto_Viagens\Banco\Viagens.mdf;";
        readonly SqlConnection conn;

        public AddressService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public bool Insert(Address address)
        {
            bool status = false;
            try
            {
                string strInsert = "INSERT INTO City (Street, Number, Neighborhood, ZipCode, Complement, RegistrationDate, Id_City) VALUES (@Street, @Number, @Neighborhood, @ZipCode, @Complement, @RegistrationDate, @Id_City); SELECT CAST(scope_identity() as int)";

                SqlCommand commandInsert = new SqlCommand(strInsert, conn);

                commandInsert.Parameters.Add(new SqlParameter("@Street", address.Street));
                commandInsert.Parameters.Add(new SqlParameter("@Number", address.Number));
                commandInsert.Parameters.Add(new SqlParameter("@Neighborhood", address.Neighborhood));
                commandInsert.Parameters.Add(new SqlParameter("@ZipCode", address.ZipCode));
                commandInsert.Parameters.Add(new SqlParameter("@Complement", address.Complement));
                commandInsert.Parameters.Add(new SqlParameter("@RegistrationDate", address.RegistrationDate));
                commandInsert.Parameters.Add(new SqlParameter("@Id_City", address.City));

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

        public List<Address> FindAll()
        {
            List<Address> addresses = new List<Address>();

            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT A.Id,");
            sb.Append(" A.Street,");
            sb.Append(" A.Number,");
            sb.Append(" A.Neighborhood,");
            sb.Append(" A.ZipCode,");
            sb.Append(" A.Complement,");
            sb.Append(" A.RegistrationDate,");
            sb.Append(" C.Description,");
            sb.Append(" FROM Address A, City C");
            sb.Append(" WHERE C.Id = A.Id_City");

            SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                Address address = new Address();

                address.Id = (int) dr["Id"];
                address.Street = (string) dr["Street"];
                address.Number = (int) dr["Number"];
                address.Neighborhood = (string) dr["Neighborhood"];
                address.ZipCode = (string) dr["ZipCode"];
                address.Complement = (string) dr["Complement"];
                address.RegistrationDate = (DateTime) dr["RegistrationDate"];
                address.City = new City() 
                { 
                    Id = (int) dr["Id_City"],
                    Description = (string) dr["Description"],
                    RegistrationDate = (DateTime) dr["RegistrationDate_City"]
                };

                addresses.Add(address);
            }
            return addresses;
        }
    }
}
