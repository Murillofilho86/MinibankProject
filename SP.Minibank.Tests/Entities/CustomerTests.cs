using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SP.Minibank.Domain.Entities;
using SP.Minibank.Domain.Enums;
using SP.Minibank.Domain.ValueObjects;

namespace SP.Minibank.Tests.Entities
{
    [TestClass]
    public class CustomerTests
    {
        private Customer _customer;

        public CustomerTests()
        {
            var name = new Name("Rick", "Sanchez Ltda");
            var document = new Document("56702361000134", ECustomerDocument.CPNJ);
            var email = new Email("ricksanchez@citadel.com");
            var birth = new DateTime(1946, 09, 30);
            _customer = new Customer(name, email, birth, document, "2569-6969");
        }

        [TestMethod]
        public void ShouldCreateCustomerWhenValid()
        {
                Assert.AreEqual(true, _customer.Valid);
        }
    }
}