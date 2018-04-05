using System;

namespace SP.Minibank.Domain.Commands.AccountCommands.Inputs
{
    public class CreateAccountCommand
    {
        public Guid Customer { get; set; }
    }
}