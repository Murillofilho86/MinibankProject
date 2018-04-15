using Dapper;
using SP.Minibank.Domain.Entities;
using SP.Minibank.Domain.Repositories;
using SP.Minibank.Infra.MinibankContext.DataContexts;

namespace SP.Minibank.Infra.MinibankContext.Repositories
{
    public class AccountRepository : IAccountRepository
    {
       private readonly DataContext _context;

        public AccountRepository(DataContext context)
        {
            _context = context;
        }

   
        public void Save(Account account)
        {
            throw new System.NotImplementedException();
        }
    }
}