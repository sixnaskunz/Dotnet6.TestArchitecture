using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dotnet6.TestArchitecture.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service; 
        }

        // GET: /<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _service.GetAllCustomer();
        }
    }
}
