using Study_DDD.Domain.Interfaces;
using Study_DDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_DDD.Infrastruct.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public Customer GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
