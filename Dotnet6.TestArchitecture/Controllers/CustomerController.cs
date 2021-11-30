using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dotnet6.TestArchitecture.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: /<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            Random random = new();
            return new List<Customer>
            {
                new Customer { Id = Guid.NewGuid(), FirstName = "Warune", LastName = "Pondsuraparb", Age = random.Next(0, 100) },
                new Customer { Id = Guid.NewGuid(), FirstName = "SixnaskUnz", LastName = "Zenate", Age = random.Next(0, 100) },
                new Customer { Id = Guid.NewGuid(), FirstName = "Plasmic", LastName = "Zenate", Age = random.Next(0, 100) },
            };
        }
    }
}
