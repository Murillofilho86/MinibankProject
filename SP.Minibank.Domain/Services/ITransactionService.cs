using SP.Minibank.Domain.Enums;

namespace SP.Minibank.Domain.Services
{
    public interface ITransactionService
    {
           void AddTransaction(string idCustomer, string idAccount, decimal valueTransaction, ETransactionType type);
    }
}