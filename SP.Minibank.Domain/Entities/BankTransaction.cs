using System;
using SP.Minibank.Shared.Entities;

namespace SP.Minibank.Domain.Entities
{
    public class BankTransaction : EntityBase
    {
        public BankTransaction(Account account, Decimal value)
        {
            DateTransaction = DateTime.Now;
            Account = account;
            ValueTransaction = value;
        }

        public Account Account { get; private set; }
        public DateTime DateTransaction { get; private set; }
        public decimal ValueTransaction { get; private set; }
  

        public override string ToString()
        {
            return DateTransaction + ", " + ValueTransaction;
        }
    }
}