using System;
using SP.Minibank.Shared.Entities;

namespace SP.Minibank.Domain.Entities
{
    public class Deposit : BankTransaction
    {
        public Deposit(DateTime dateTransaction, decimal value) : base(dateTransaction, value)
        {
        }

        public override void AddTransaction()
        {
            throw new NotImplementedException();
        }
    }
}