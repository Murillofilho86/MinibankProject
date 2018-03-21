using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidator;
using SP.Minibank.Domain.Enums;
using SP.Minibank.Domain.ValueObjects;

namespace SP.Minibank.Domain.Entities
{
    public class Customer
    {
        private readonly IList<Address> _addAdresses;
        public Customer(
          Name name,
           Email email,
           DateTime birthDate,
           string document,
           ECustomerDocument type,
           string phone
           )
        {

            Name = name;
            Email = email;
            BirthDate = birthDate;
            Document = document;
            Type = type;
            Phone = phone;
            Accounts = new List<Account>();
            Transactions = new List<Transaction>();
            _addAdresses = new List<Address>();
        }
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public ECustomerDocument Type { get; private set; }
        public string Document { get; set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Address => _addAdresses.ToArray();
        public IReadOnlyCollection<Account> Accounts { get; private set; }
        public IReadOnlyCollection<Transaction> Transactions { get; set; }


        public void AddAddresses(Address address)
        {
            _addAdresses.Add(address);
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}