using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SP.Minibank.Domain.Commands.CustomerCommands.Inputs;
using SP.Minibank.Domain.Commands.CustomerCommands.Outputs;
using SP.Minibank.Domain.Entities;
using SP.Minibank.Domain.Handlers;
using SP.Minibank.Domain.Queries;
using SP.Minibank.Domain.Repositories;
using SP.Minibank.Shared.Commands;

namespace SP.Minibank.API.Controllers
{
    public class CustomerController
    {
        private readonly ICustomerRepository _respository;
        private readonly CustomerHandler _handler;

        public CustomerController(ICustomerRepository repository, CustomerHandler handler)
        {
            _respository = repository;
            _handler = handler;
        }


        [HttpGet]
        [Route("v1/customers")]
        public IEnumerable<ListCustomerQueryResult> Get()
        {
            return _respository.Get();
        }

        [HttpGet]
        [Route("v1/customers/{id}")]
        public GetCustomerQueryResult GetById(Guid id)
        {
            return _respository.GetById(id);
        }

        [HttpGet]
        [Route("v1/customers/{id}/account")]
        public List<Account> GetAccount([FromBody]Customer customer)
        {
            return null;
        }

         [HttpPost]
         [Route("v1/customers")]
         public ICommandResult Post([FromBody]CreateCustomerCommand command)
         {
             var result = (CreateCustomerCommandResult)_handler.Handle(command);
             return result;
         }

        [HttpPut]
        [Route("v1/customers/{id}")]
        public Customer Put(Customer customer)
        {
            return null;
        }

        [HttpDelete]
        [Route("v1/customers/{id}")]
        public object Delete()
        {
            return new { message = "Excluído com sucesso." };
        }

    }
}