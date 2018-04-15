using FluentValidator;
using SP.Minibank.Domain.Commands.AccountCommands.Inputs;
using SP.Minibank.Domain.Entities;
using SP.Minibank.Domain.Repositories;
using SP.Minibank.Shared.Commands;

namespace SP.Minibank.Domain.Handlers
{
    public class AccountHandler
    : Notifiable,
    ICommandHandler<CreateAccountCommand>
    {
        private readonly IAccountRepository _accountRepository;
        private readonly ICustomerRepository _customerRepository;

        public AccountHandler(IAccountRepository accountRepository, ICustomerRepository customerRepository)
        {
            _accountRepository = accountRepository;
            _customerRepository = customerRepository;
        }

        public ICommandResult Handle(CreateAccountCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}