using System;
using FluentValidator;
using FluentValidator.Validation;
using SP.Minibank.Domain.Enums;
using SP.Minibank.Shared.Commands;

namespace SP.Minibank.Domain.Commands.AccountCommands.Inputs
{
    public class CreateAccountCommand : Notifiable, ICommand
    {
        public string Agency { get; set; }
        public string NumberAccount { get; set; }
        public string digit { get; set; }
        public decimal Balance { get; set; }
        public EAccountStatus Status { get; set; }
        public DateTime DateCreated { get; set; }


        public bool IsValid()
        {
            AddNotifications(new ValidationContract()
            .Requires()
            .HasMinLen(Agency, 4, "Agency", "A agencia deve conter pelo menos 4 caracteres")
            .HasMaxLen(Agency, 4, "Agency", "A agencia deve conter no máximo 4 caracteres")
            .HasMinLen(NumberAccount, 5, "NumberAccount", "O número deve ter no minimo 5 caracteres")
            .HasMaxLen(NumberAccount, 5, "NumberAccount", "O número deve ter no máximo 5 caracteres")
            .HasMinLen(digit, 1, "digit", "O dígito verificador deve ter no minimo 5 caracteres")
            .HasMaxLen(digit, 1, "digit", "O dígito verificador deve ter no máximo 5 caracteres")
            );

            return Valid;
        }
    }
}