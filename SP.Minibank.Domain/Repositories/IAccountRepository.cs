using SP.Minibank.Domain.Entities;

namespace SP.Minibank.Domain.Repositories
{
    public interface IAccountRepository
    {
        void Save(Account account);
    }
}