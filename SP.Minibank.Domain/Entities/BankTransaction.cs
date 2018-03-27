using System;
using SP.Minibank.Shared.Entities;

namespace SP.Minibank.Domain.Entities
{
    public class BankTransaction : EntityBase
    {
           public BankTransaction(DateTime dateTransaction, decimal value)
      {
          DateTransaction = DateTime.Now;
          ValueTransaction = value;
      }

        public DateTime DateTransaction { get; set; }
        public decimal ValueTransaction { get; set; }

              
         
        public override string ToString()
        {
            return DateTransaction + ", " + ValueTransaction;
        }
    }
}