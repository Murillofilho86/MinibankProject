using FluentValidator;
using FluentValidator.Validation;

namespace SP.Minibank.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(new ValidationContract()
               .Requires()
               .IsEmail(Address, "Email", "o E-mail é inválido")

           );

        }

        public string Address { get; private set; }

        public override string ToString()
        {
            return Address;
        }
    }
}