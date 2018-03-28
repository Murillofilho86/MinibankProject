using SP.Minibank.Domain.Entities;
using SP.Minibank.Domain.Repositories;
using SP.Minibank.Infra.MinibankContext.DataContexts;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace SP.Minibank.Infra.MinibankContext.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public bool CheckDocument(string document)
        {
            return _context
                .Connection
                .Query<bool>(
                "spCheckDocument",
                    new { Document = document },
                    commandType: CommandType.StoredProcedure)
                    .FirstOrDefault();

        }


        public bool CheckEmail(string email)
        {
            return _context
                .Connection
                .Query<bool>(
                    "spCheckEmail",
                    new { Email = email },
                    commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
        }

        public void Save(Customer customer)
        {
            _context.Connection.Execute("spCreateCustomer",
            new
            {
                Id = customer.Id,
                Firstname = customer.Name.FirstName,
                LastName = customer.Name.LastName,
                Document = customer.Document.Number,
                Email = customer.Email.Address,
                BirthDate = customer.BirthDate,
                Phone = customer.Phone

            }, commandType: CommandType.StoredProcedure);

            foreach (var address in customer.Addresses)
            {
                _context.Connection.Execute("spCreateAddress",
                new
                {
                    Id = address.Id,
                    CustomerId = customer.Id,
                    Number = address.Number,
                    District = address.District,
                    City = address.City,
                    State = address.State,
                    Country = address.Country,
                    ZipCode = address.ZipeCode
                }, commandType: CommandType.StoredProcedure);
            }
        }
    }
}