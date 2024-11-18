using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface ICustomerRepository
    {
        public Task<IEnumerable<Customer>> GetCustomersAsync();
        public Task<Customer> AddCustomer(Customer customer);
    }
}
