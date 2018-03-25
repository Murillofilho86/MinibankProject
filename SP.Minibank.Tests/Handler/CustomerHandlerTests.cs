using Microsoft.VisualStudio.TestTools.UnitTesting;
using SP.Minibank.Domain.Commands.CustomerCommands.Inputs;
using SP.Minibank.Domain.Handlers;
using SP.Minibank.Tests.Mocks;

namespace SP.Minibank.Tests.Handler
{
    [TestClass]
    public class CustomerHandlerTests
    {
           [TestMethod]
        public void ShouldRegisterCustomerWhenCommandIsValid()
        {
          var command = new CreateCustomerCommand();   
          command.FirstName = "O Grande";
          command.LastName = "Saitama";
          command.Document = "16321365203";
          command.Email = "sai@tama.com.br";
          command.Phone = "2560-6969";
          command.BirthDate = "19/04/1970";

          var handler = new CustomerHandler(new MockCustomerRepository(), new MockEmailService());
          var result = handler.Handle(command);

          Assert.AreNotEqual(null, result);
          Assert.AreEqual(true, handler.Valid);
        }
    }
}   
