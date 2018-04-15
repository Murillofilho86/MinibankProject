using System;
using SP.Minibank.Shared.Commands;
using FluentValidator;
using FluentValidator.Validation;

namespace SP.Minibank.Domain.Commands.AccountCommands.Outputs
{
    public class CommandResult : ICommandResult
    {
        public CommandResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
    }
}