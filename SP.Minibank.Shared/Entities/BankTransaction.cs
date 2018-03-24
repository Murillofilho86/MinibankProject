using System;

namespace SP.Minibank.Shared.Entities
{
    public abstract class BankTransaction : EntityBase
    {
      public BankTransaction(DateTime dateTransaction, decimal value)
      {
          DateTransaction = DateTime.Now;
          ValueTransaction = value;
      }

        public DateTime DateTransaction { get; set; }
        public decimal ValueTransaction { get; set; }

        public abstract void AddTransaction();
        
        public override string ToString()
        {
            return DateTransaction + ", " + ValueTransaction;
        }
    }
}