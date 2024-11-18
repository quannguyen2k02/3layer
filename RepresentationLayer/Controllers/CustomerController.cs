using BusinessLogicLayer;
using DataAccessLayer.DataDTO;
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
        public async Task<IActionResult> AddCustomer(CustomerDTO customer)
        {
            if(ModelState.IsValid)
            {
                var c = await _customerService.AddCustomerAsync(customer);
                return Ok(c);
            }
            return BadRequest();
        }
    }
}
