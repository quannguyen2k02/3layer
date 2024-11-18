using DataAccessLayer.DataDTO;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer
{
    public interface ICustomerService
    {
        public Task<IEnumerable<CustomerDTO>> GetCustomersAsync();
        public Task<Customer> AddCustomerAsync(CustomerDTO customer);
    }
}
