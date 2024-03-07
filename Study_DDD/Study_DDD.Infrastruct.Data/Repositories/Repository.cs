using Study_DDD.Domain.Interfaces;
using Study_DDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_DDD.Infrastruct.Data.Repositories
{
    public class Repository<TEntity> : IRepository<Customer>
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
