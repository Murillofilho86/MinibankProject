using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SP.Minibank.Domain.Entities;
using SP.Minibank.Domain.ValueObjects;

namespace SP.Minibank.API.Controllers
{
    public class CustomerController
    {
        [HttpGet]
        [Route("customers")]
        public List<Customer> Get()
        {
            return null;
        }

        [HttpGet]
        [Route("customers/{id}")]
        public Customer GetById(Guid id)
        {
            return null;
        }

        [HttpGet]
        [Route("customers/{id}/account")]
        public List<Account> GetAccount([FromBody]Customer customer)
        {
            return null;
        }

        [HttpPost]
        [Route("customers")]
        public Customer Post()
        {
            return null;
        }

        [HttpPut]
        [Route("customers/{id}")]
        public Customer Put(Customer customer)
        {
            return null;
        }

        [HttpDelete]
        [Route("customers/{id}")]
        public object Delete()
        {
            return new { message = "Excluído com sucesso."};
        }

    }
}