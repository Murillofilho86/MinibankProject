using System;
using SP.Minibank.Shared.Entities;

namespace SP.Minibank.Domain.Entities
{
    public abstract class Transaction : EntityBase
    {
        protected Transaction(Account account, decimal valueTransaction)
        {
            Account = account;
            DateTransaction = DateTime.Now;
            ValueTransaction = valueTransaction;
        }

        public Account Account { get; private set; }
        public DateTime DateTransaction { get; private set; }
        public decimal ValueTransaction { get; private set; }
  
        public abstract string addTransaction(Account account, DateTime dateTransaction);

        public override string ToString()
        {
            return DateTransaction + ", " + ValueTransaction;
        }
    }
}