using System;
using SP.Minibank.Shared.Commands;

namespace SP.Minibank.Domain.Commands.CustomerCommands.Outputs
{
    public class CreateAccountCommandResult : ICommandResult
    {

        public CreateAccountCommandResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

    }
}