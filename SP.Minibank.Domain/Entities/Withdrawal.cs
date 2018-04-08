using System;
using SP.Minibank.Domain.Enums;
using SP.Minibank.Domain.Services;

namespace SP.Minibank.Domain.Entities
{
    public class Withdrawal : Transaction
    {
        protected Withdrawal(Account account, decimal valueTransaction)
        : base(account, valueTransaction) { }
        
        public override string addTransaction(Account account, DateTime dateTransaction)
        {
            throw new NotImplementedException();
        }
    }
}