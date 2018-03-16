using System;
using System.Collections.Generic;
using SP.Minibank.Domain.Enums;

namespace SP.Minibank.Domain.Entities
{
    public class Customer
    {
         public Customer(
            string firstName, 
            string lastName, 
            string email, 
            DateTime birthDate, 
            ECustomerDocument document, 
            string contact, 
            string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
            Document = document;
            Contact = contact;
            Address = address;
            Accounts = new List<Account>();
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public ECustomerDocument Document { get; private set; }
        public string Contact { get; private set; }
        public string Address { get; private set; }
        public IList<Account> Accounts { get; private set; }

        public override string ToString(){
            return $"{FirstName} {LastName}";
        }
    }
}