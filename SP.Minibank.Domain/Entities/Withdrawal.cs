using System;
using System.Transactions;
using SP.Minibank.Domain.ValueObjects;
using SP.Minibank.Shared.Entities;

namespace SP.Minibank.Domain.Entities
{
    public class Withdrawal : BankTransaction
    {
        public Withdrawal(DateTime dateTransaction, decimal value) : base(dateTransaction, value)
        {
        }

        public override void AddTransaction()
        {
            throw new NotImplementedException();
        }
    }
}