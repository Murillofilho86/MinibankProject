using System;
using System.Collections.Generic;
using SP.Minibank.Domain.Entities;
using SP.Minibank.Domain.Queries;

namespace SP.Minibank.Domain.Repositories
{
    public interface ICustomerRepository
    {
         bool CheckDocument(string document);
         bool CheckEmail(string email);
         void Save(Customer customer);
         IEnumerable<ListCustomerQueryResult> Get();
         GetCustomerQueryResult GetById(Guid id);
    }
}