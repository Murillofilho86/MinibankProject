using System;
using System.Collections.Generic;
using System.Linq;
using SP.Minibank.Domain.Enums;
using SP.Minibank.Shared.Entities;

namespace SP.Minibank.Domain.Entities
{
    public class Account : EntityBase
    {
        private readonly IList<BankTransaction> _bankTransaction;

        public Account(Customer customer)
        {
            Costumer = customer;
            DateCreated = DateTime.Now;
            Status = EAccountStatus.Created;
            Agency = "7157";
            NumberAccount = "23675 - 4";
        }

        public Account(string numberAccount, decimal balance, string agency, string numberDocument, ETransactionType type, EAccountStatus status, DateTime dateCreated, Customer costumer)
        {
            NumberAccount = numberAccount;
            Balance = balance;
            Agency = agency;
            NumberDocument = numberDocument;
            Type = type;
            Status = status;
            DateCreated = dateCreated;
            Costumer = costumer;

        }
        public string NumberAccount { get; private set; }
        public decimal Balance { get; private set; }
        public string Agency { get; private set; }
        public string NumberDocument { get; set; }
        public ETransactionType Type { get; private set; }
        public EAccountStatus Status { get; private set; }
        public DateTime DateCreated { get; private set; }
        public Customer Costumer { get; private set; }
        public IReadOnlyCollection<BankTransaction> BankTransaction => _bankTransaction.ToArray();


        public void AddAccountTransaction(IList<BankTransaction> transactions)
        {
            foreach (var transaction in transactions)
                transaction.AddTransaction();
            
        }

        public override string ToString()
        {
            return NumberAccount;
        }
    }
}