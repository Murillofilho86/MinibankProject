using System;
using SP.Minibank.Shared.Entities;

namespace SP.Minibank.Domain.Entities
{
    public class Transaction : EntityBase
    {
        public Transaction(Customer customer, Account account, decimal value)
        {
            Customer = customer;
            Account = account;
            DateTransaction = DateTime.Now;
            ValueTransaction = value;
     
        }

        public Customer Customer { get; private set; }
        public Account Account { get; set; }
        public DateTime DateTransaction { get; private set; }
        public decimal ValueTransaction { get; private set; }


     
        public override string ToString()
        {
            return Customer.Name + ", " + DateTransaction + ", " + ValueTransaction + ", " + Account.Balance;
        }
    }
}