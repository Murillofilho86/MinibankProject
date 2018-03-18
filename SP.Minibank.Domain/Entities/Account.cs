using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidator;
using SP.Minibank.Domain.Enums;

namespace SP.Minibank.Domain.Entities
{
    public class Account : Notifiable
    {
        private readonly IList<Transaction> _transaction;
        public Account(Customer customer)
        {
            Costumer = customer;
            DateCreated = DateTime.Now;
            Status = EAccountStatus.Created;
            Agency = "7157";
            NumberAccount = "23675 - 4";
            _transaction = new List<Transaction>();

           
        }

        public string NumberAccount { get; private set; }
        public decimal Balance { get; private set; }
        public string Agency { get; private set; }
           public string NumberDocument { get; set; }
        public EAccountType Type { get; private set; }
        public EAccountStatus Status { get; private set; }
        public DateTime DateCreated { get; private set; }
        public Customer Costumer { get; private set; }
        public IReadOnlyCollection<Transaction> Transactions => _transaction.ToArray();

        public void AddAccount(Customer customer)
        {   
            
        }

        public void AddBankTransaction(Transaction transaction)
        {
            //Adiciona uma transação na conta
        }

    }
}