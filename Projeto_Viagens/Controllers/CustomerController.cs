using Projeto_Viagens_ADO.NET.Models;
using Projeto_Viagens_ADO.NET.Services;

namespace Projeto_Viagens_ADO.NET.Controllers
{
    public class CustomerController
    {
        public bool Insert(Customer customer, int id)
        {
            return new CustomerService().Insert(customer, id);
        }

        public bool Update(Customer customer, int id)
        {
            return new CustomerService().Update(customer, id);
        }

        public bool Delete(int id)
        {
            return new CustomerService().Delete(id);
        }

        public List<Customer> FindAll()
        {
            return new CustomerService().FindAll();
        }
    }
}
