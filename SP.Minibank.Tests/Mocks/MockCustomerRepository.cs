using System;
using System.Collections.Generic;
using SP.Minibank.Domain.Entities;
using SP.Minibank.Domain.Queries;
using SP.Minibank.Domain.Repositories;

namespace SP.Minibank.Tests.Mocks
{
    public class MockCustomerRepository : ICustomerRepository
    {
        public bool CheckDocument(string document)
        {
            return false;
        }

        public bool CheckEmail(string email)
        {
            return false;
        }

        public IEnumerable<ListCustomerQueryResult> Get()
        {
            throw new NotImplementedException();
        }

        public GetCustomerQueryResult GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save(Customer customer)
        {
           
        }
    }
}