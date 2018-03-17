using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SP.Minibank.Domain.Entities;
using SP.Minibank.Domain.Enums;

namespace SP.Minibank.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer("Murillo", "Josa", "murillo@gmail.com", DateTime.Now, ECustomerDocument.CPF, "2569-6969");
        }
    }
}
