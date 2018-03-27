using SP.Minibank.Domain.Enums;
using SP.Minibank.Domain.Services;

namespace SP.Minibank.Domain.Entities
{
    public class Withdrawal : ITransactionService
    {
        public void AddTransaction(string idCustomer, string idAccount, decimal valueTransaction, ETransactionType type)
        {
            throw new System.NotImplementedException();
        }
    }
}