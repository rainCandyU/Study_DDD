using Study_DDD.Application.Interfaces;
using Study_DDD.Application.ViewModels;
using Study_DDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_DDD.Application.Services
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICustomerRepository _customerRepository;

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public CustomerViewModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Register(CustomerViewModel customerViewModel)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerViewModel customerViewModel)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
