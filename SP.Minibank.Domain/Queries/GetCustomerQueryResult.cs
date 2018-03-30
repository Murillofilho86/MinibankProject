using System;

namespace SP.Minibank.Domain.Queries
{
    public class GetCustomerQueryResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string BirthDate { get;  set; }
        public string Phone { get; private set; }
    }
}