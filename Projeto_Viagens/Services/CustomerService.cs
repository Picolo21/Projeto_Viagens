using Projeto_Viagens.Models;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_Viagens.Services
{
    public class CustomerService
    {
        readonly string strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\Projeto_Viagens\Database\Viagens.mdf";
        readonly SqlConnection conn;

        public CustomerService()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public bool Insert(Customer customer, int id)
        {
            bool status = false;
            try
            {
                string strInsert = "INSERT INTO Customer (CustomerName, Phone, RegistrationDate, IdAddress) VALUES (@CustomerName, @Phone, @RegistrationDate, @IdAddress)";

                SqlCommand commandInsert = new SqlCommand(strInsert, conn);

                commandInsert.Parameters.Add(new SqlParameter("@CustomerName", customer.CustomerName));
                commandInsert.Parameters.Add(new SqlParameter("@Phone", customer.Phone));
                commandInsert.Parameters.Add(new SqlParameter("@RegistrationDate", customer.RegistrationDate));
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

        public bool Update(Customer customer, int id)
        {
            bool status = false;
            try
            {
                string strUpdate = "UPDATE Customer SET CustomerName = @CustomerName, Phone = @Phone, RegistrationDate = @RegistrationDate WHERE Id = @Id";

                SqlCommand commandUpdate = new SqlCommand(strUpdate, conn);

                commandUpdate.Parameters.Add(new SqlParameter("@Id", id));
                commandUpdate.Parameters.Add(new SqlParameter("@Customer", customer.CustomerName));
                commandUpdate.Parameters.Add(new SqlParameter("@Phone", customer.Phone));
                commandUpdate.Parameters.Add(new SqlParameter("@RegistrationDate", customer.RegistrationDate));

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
                string strDelete = $"DELETE FROM Customer WHERE Id = @Id";

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

        public List<Customer> FindAll()
        {
            List<Customer> customers = new List<Customer>();

            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT C.Id,");
            sb.Append(" C.[CustomerName],");
            sb.Append(" C.Phone,");
            sb.Append(" C.RegistrationDate,");
            sb.Append(" A.Street,");
            sb.Append(" A.Number,");
            sb.Append(" A.Neighborhood,");
            sb.Append(" A.PostalCode,");
            sb.Append(" A.Complement,");
            sb.Append(" A.RegistrationDate AS RegistrationDateAddress,");
            sb.Append(" Ci.[CityName],");
            sb.Append(" Ci.RegistrationDate AS RegistrationDateCity");
            sb.Append(" FROM Customer C, [Address] A, City Ci");
            sb.Append(" WHERE C.IdAddress = A.Id AND A.IdCity = Ci.Id");

            SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                Customer customer = new Customer();

                customer.Id = (int)dr["Id"];
                customer.CustomerName = (string)dr["CustomerName"];
                customer.Phone = (string)dr["Phone"];
                customer.RegistrationDate = (DateTime)dr["RegistrationDate"];
                customer.Address = new Address
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
                customers.Add(customer);
            };
            return customers;
        }
    }
}
