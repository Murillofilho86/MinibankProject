using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SP.Minibank.Domain.Entities;
using SP.Minibank.Domain.Enums;
using SP.Minibank.Domain.ValueObjects;

namespace SP.Minibank.Tests.Entities
{
    [TestClass]
    public class AccountTests
    {
        private Customer _customer;
        public AccountTests()
        {
            var name = new Name("Rick", "Sanchez");
            var document = new Document("22422418341", ECustomerDocument.CPF);
            var email = new Email("rick@hotmail.com");
            var birth = new DateTime(1946, 09, 30);
            _customer = new Customer(name, email, birth, document, "2569-6969");
        }

        [TestMethod]
        public void ShouldCreateAccountWhenValid()
        {

        }

    }
}