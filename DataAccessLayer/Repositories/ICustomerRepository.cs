using DataAccessLayer.Entities;

namespace DataAccessLayer.Interface
{
    public interface ICustomerRepository
    {
        public Task<IEnumerable<Customer>> GetCustomersAsync();
        public Task<Customer> AddCustomer(Customer customer);
    }
}
