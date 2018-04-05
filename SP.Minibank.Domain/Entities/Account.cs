using System;
using System.Collections.Generic;
using System.Linq;
using SP.Minibank.Domain.Enums;
using SP.Minibank.Shared.Entities;

namespace SP.Minibank.Domain.Entities
{
    public class Account : EntityBase
    {


        public Account(Customer customer, string agency, string numberAccount, decimal balance)
        {
            Customer = customer;
            NumberAccount = numberAccount;
            Balance = balance;
            Agency = agency;
            DateCreated = DateTime.Now;
        }

        public string Agency { get; private set; }
        public string NumberAccount { get; private set; }
        public decimal Balance { get; private set; }
        public EAccountStatus Status { get; private set; }
        public DateTime DateCreated { get; private set; }
        public Customer Customer { get; private set; }



        public override string ToString()
        {
            return NumberAccount;
        }
    }
}