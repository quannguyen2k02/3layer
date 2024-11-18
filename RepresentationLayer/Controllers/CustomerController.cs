using BusinessLogicLayer;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService) {
            _customerService = customerService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCustomer()
        {
            var customers = await _customerService.GetCustomersAsync();
            return Ok(customers);
        }
        [HttpPost]
        public async Task<IActionResult> AddNewCustomer(Customer customer)
        {
            var c  = await _customerService.AddNewCustomerAsync(customer);
            return Ok(c);
        }
    }
}
