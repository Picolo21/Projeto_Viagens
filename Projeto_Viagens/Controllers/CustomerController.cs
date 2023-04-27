using Projeto_Viagens.Models;
using Projeto_Viagens.Services;

namespace Projeto_Viagens.Controllers
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
