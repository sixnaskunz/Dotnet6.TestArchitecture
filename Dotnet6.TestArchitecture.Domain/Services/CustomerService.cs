using Dotnet6.TestArchitecture.Domain.Entities;
using Dotnet6.TestArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet6.TestArchitecture.Domain.Services
{
    public class CustomerService : ICustomerService
    {

        public ICollection<Customer> GetAllCustomer()
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
