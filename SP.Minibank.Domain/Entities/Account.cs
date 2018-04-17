using System;
using System.Collections.Generic;
using System.Linq;
using SP.Minibank.Domain.Enums;
using SP.Minibank.Shared.Entities;

namespace SP.Minibank.Domain.Entities
{
    public class Account : EntityBase
    {
        private readonly IList<Transaction> _transaction;
        public Account(Customer customer, string agency, string numberAccount, decimal balance)
        {
            Customer = customer;
            NumberAccount = numberAccount;
            Balance = balance;
            Agency = agency;
            DateCreated = DateTime.Now;
            _transaction = new List<Transaction>();
        }

        public string Agency { get; private set; }
        public string NumberAccount { get; private set; }
        public string Digit { get; private set; }
        public decimal Balance { get; private set; }
        public EAccountStatus Status { get; private set; }
        public DateTime DateCreated { get; private set; }
        public Customer Customer { get; private set; }
        public IReadOnlyCollection<Transaction> Transactions => _transaction.ToArray();


        public void AddDeposit(Guid id, decimal value){
            if(value >= 0)
                AddNotification("Value", "Não é possível depositar o valor informado: {value}");
            
            Balance += value;
           
            var transaction = new Transaction(id, value, ETransactionType.Deposit);
            _transaction.Add(transaction);
        }


        public void AddWithdrawal(Guid id, decimal value){
            if(Balance <= 0)
                AddNotification("Balance", $"Saldo {Balance} indisponível");
          
           if(value <= 0)
                AddNotification("Value", "Não é possível sacar o valor informado {value}");

            Balance -= value;
          
            var transaction = new Transaction(id, value, ETransactionType.Withdrawal);
            _transaction.Add(transaction);
        }


        public override string ToString()
        {
            return NumberAccount;
        }
    }
}