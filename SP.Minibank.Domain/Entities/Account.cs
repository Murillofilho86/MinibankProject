using System;
using System.Collections.Generic;
using SP.Minibank.Domain.Enums;

namespace SP.Minibank.Domain.Entities
{
    public class Account
    {
        public Account(Customer customer)
        {
            Costumer = customer;
            DateCreated = DateTime.Now;
            Status = EAccountStatus.Created;
        }

        public long NumberAccount { get; private set; }
        public int Code { get; private set; }
        public decimal Balance { get; private set; }
        public string Agency { get; private set; }
        public EAccountType Type { get; private set; }
        public EAccountStatus Status { get; private set; }
        public DateTime DateCreated { get; private set; }
        public Customer Costumer { get; private set; }
        public IReadOnlyCollection<Transaction> Transactions { get; private set; }

    }
}