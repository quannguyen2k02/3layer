using AutoMapper;
using DataAccessLayer.DataDTO;
using DataAccessLayer.Entities;
using DataAccessLayer.Interface;

namespace BusinessLogicLayer
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper) {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<Customer> AddCustomerAsync(CustomerDTO customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "Customer cannot be null.");
            }
            var c = _mapper.Map<Customer>(customer);
            var customer1 = await _customerRepository.AddCustomer(c);
            return customer1;
        }

        public async Task<IEnumerable<CustomerDTO>> GetCustomersAsync()
        {
            var customers = await _customerRepository.GetCustomersAsync();
            var customerDTOs = _mapper.Map<IEnumerable<CustomerDTO>>(customers);
            return customerDTOs;
        }
    }
}
