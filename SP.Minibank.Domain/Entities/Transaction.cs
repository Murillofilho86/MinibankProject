using System;
using SP.Minibank.Domain.Enums;
using SP.Minibank.Shared.Entities;

namespace SP.Minibank.Domain.Entities
{
    public class Transaction : EntityBase
    {
        public Transaction(Guid id, decimal valueTransaction, ETransactionType transactionType)
        {
            AccountId = id;
            DateTransaction = DateTime.Now;
            ValueTransaction = valueTransaction;
            Type = transactionType;
        }

        public Guid AccountId { get; private set; }
        public DateTime DateTransaction { get; private set; }
        public decimal ValueTransaction { get; private set; }
        public ETransactionType Type { get; private set; }
        
        public override string ToString()
        {
            return DateTransaction + ", " + ValueTransaction;
        }
    }
}