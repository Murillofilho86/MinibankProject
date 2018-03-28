using System;
using System.Collections.Generic;
using System.Linq;
using SP.Minibank.Domain.ValueObjects;
using SP.Minibank.Shared.Entities;

namespace SP.Minibank.Domain.Entities
{
    public class Customer : EntityBase
    {
        private readonly IList<Address> _addresses;
        public Customer(
          Name name,
           Email email,
           DateTime birthDate,
           Document document,
           string phone
           )
        {

            Name = name;
            Email = email;
            BirthDate = birthDate;
            Document = document;
            Phone = phone;
            Accounts = new List<Account>();
            _addresses = new List<Address>();
        }
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Document Document { get; set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();
        public IReadOnlyCollection<Account> Accounts { get; private set; }


        public void AddAddresses(Address address)
        {
            _addresses.Add(address);
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}