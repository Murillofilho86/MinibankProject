using System;
using SP.Minibank.Domain.Entities;

namespace SP.Minibank.Domain.Services
{
    public interface ITransactionService
    {
         string addTransaction(Account account, DateTime dateTransaction);

    }
}