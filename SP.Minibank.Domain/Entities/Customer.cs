using System;
using System.Collections.Generic;
using System.Linq;
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
           ECustomerDocument document,
           string contact
           )
        {

            Name = name;
            Email = email;
            BirthDate = birthDate;
            Document = document;
            Contact = contact;
            _addAdresses = new List<Address>();
            Accounts = new List<Account>();
            Transactions = new List<Transaction>();

        }
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public ECustomerDocument Document { get; private set; }
        public string Contact { get; private set; }
        public IReadOnlyCollection<Address> Address => _addAdresses.ToArray();
        public IList<Account> Accounts { get; private set; }
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