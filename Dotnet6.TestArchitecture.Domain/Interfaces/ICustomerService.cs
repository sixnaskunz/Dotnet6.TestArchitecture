using Dotnet6.TestArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet6.TestArchitecture.Domain.Interfaces
{
    public interface ICustomerService
    {
        ICollection<Customer> GetAllCustomer();
    }
}
