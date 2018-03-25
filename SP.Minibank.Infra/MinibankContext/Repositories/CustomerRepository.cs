using SP.Minibank.Domain.Entities;
using SP.Minibank.Domain.Repositories;
using SP.Minibank.Infra.MinibankContext.DataContexts;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace SP.Minibank.Infra.MinibankContext.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public bool CheckDocument(string document)
        {
            throw new System.NotImplementedException();
        }

        public bool CheckEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Customer customer)
        {
            throw new System.NotImplementedException();
        }
    }
}