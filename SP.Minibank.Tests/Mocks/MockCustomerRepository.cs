using SP.Minibank.Domain.Entities;
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

        public void Save(Customer customer)
        {
           
        }
    }
}