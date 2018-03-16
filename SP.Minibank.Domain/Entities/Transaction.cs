using System;
using SP.Minibank.Domain.Enums;

namespace SP.Minibank.Domain.Entities
{
    public class Transaction
    {
         public Transaction(Customer customer)
        {
            DateTransaction = DateTime.Now;
        }
        
        public DateTime DateTransaction { get; private set; }
        public ETransactionType TypeTransaction { get; private set; }
       public decimal ValueTransaction { get; private set; }
    }
}