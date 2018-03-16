using System;
using SP.Minibank.Domain.Enums;

namespace SP.Minibank.Domain.Entities
{
    public class Transaction
    {
        public Transaction(Customer customer, ETransactionType type, decimal value)
        {
            DateTransaction = DateTime.Now;
            Customer = customer;
            ValueTransaction = value;
        }

        public Customer Customer { get; private set; }
        public DateTime DateTransaction { get; private set; }
        public ETransactionType TypeTransaction { get; private set; }
        public decimal ValueTransaction { get; private set; }
    }
}