using SP.Minibank.Domain.Entities;

namespace SP.Minibank.Domain.Repositories
{
    public interface ICustomerRepository
    {
         bool CheckDocument(string document);
         bool CheckEmail(string email);
         void Save(Customer customer);
                  
    }
}