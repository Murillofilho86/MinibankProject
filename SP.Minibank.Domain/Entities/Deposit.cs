using System;
using System.Collections.Generic;
using SP.Minibank.Domain.Enums;
using SP.Minibank.Domain.Services;

namespace SP.Minibank.Domain.Entities
{
    public class Deposit : ITransactionService
    {

        public Deposit(BankTransaction bankTransaction)
        {
            BankTransaction = bankTransaction;
        }

        public BankTransaction BankTransaction { get; set; }

        public void AddTransaction(Account account, decimal valueTransaction)
        {
            
        }
     }
}