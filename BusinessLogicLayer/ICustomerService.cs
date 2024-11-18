using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public interface ICustomerService
    {
        public Task<IEnumerable<Customer>> GetCustomersAsync();
        public Task<Customer> AddNewCustomerAsync(Customer customer);
    }
}
