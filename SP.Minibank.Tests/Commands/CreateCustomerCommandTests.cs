using Microsoft.VisualStudio.TestTools.UnitTesting;
using SP.Minibank.Domain.Commands.CustomerCommands.Inputs;

namespace SP.Minibank.Tests.Commands
{
    [TestClass]
    public class CreateCustomerCommandTests
    {
        [TestMethod]
        public void ShouldValidateWhenCommandIsValid()
        {
          var command = new CreateCustomerCommand();   
          command.FirstName = "O Grande";
          command.LastName = "Saitama";
          command.Document = "16321365203";
        
          command.Email = "sai@tama.com.br";
          command.Phone = "2560-6969";
          command.BirthDate = "19/04/1970";

          Assert.AreEqual(true, command.IsValid());
        }
    }
}