using System;

namespace SP.Minibank.Shared.Entities
{
    public abstract class BankTransaction : EntityBase
    {
     
        public DateTime DateTransaction { get; set; }
        public decimal ValueTransaction { get; set; }


     
        public override string ToString()
        {
            return  DateTransaction + ", " + ValueTransaction;
        }
    }
}