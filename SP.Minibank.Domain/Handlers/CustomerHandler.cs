using System;
using FluentValidator;
using SP.Minibank.Domain.Commands.CustomerCommands.Inputs;
using SP.Minibank.Domain.Commands.CustomerCommands.Outputs;
using SP.Minibank.Domain.Entities;
using SP.Minibank.Domain.Enums;
using SP.Minibank.Domain.Repositories;
using SP.Minibank.Domain.Services;
using SP.Minibank.Domain.ValueObjects;
using SP.Minibank.Shared.Commands;

namespace SP.Minibank.Domain.Handlers
{
    public class CustomerHandler : 
    Notifiable, 
    ICommandHandler<CreateCustomerCommand>,
    ICommandHandler<AddAddressCommand>
    {
        private readonly ICustomerRepository _repository;
        private readonly IEmailService _emailService;
        public CustomerHandler(ICustomerRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

        public ICommandResult Handle(CreateCustomerCommand command)
        {
           //Verificar se Documento já existe na base
           if(_repository.CheckDocument(command.Document))
                AddNotification("Document", "Este " + command.Document + " já está em uso.");

           //Verificar se email já existe na base
           if(_repository.CheckEmail(command.Email))    
            AddNotification("Email", "Este E-mail já está em uso");

           //Criar VOs
           var name = new Name(command.FirstName, command.LastName);
           var document = new Document("38384041229", ECustomerDocument.CPF);
           var email = new Email("sai@tama.com.br");

           //Criar Entidades
           var customer = new Customer(name, email, DateTime.Now, document, command.Phone);

           //Validar Entidades e VOs
           AddNotifications(name.Notifications);
           AddNotifications(document.Notifications);
           AddNotifications(email.Notifications);
           AddNotifications(customer.Notifications);

           if(Invalid)
                return null;

           //Persistir Cliente
           _repository.Save(customer);

          
           //Retornar Resultado pra tela
           return new CreateCustomerCommandResult(Guid.NewGuid(), name.ToString(), email.Address);
        }


        public ICommandResult Handle(AddAddressCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}