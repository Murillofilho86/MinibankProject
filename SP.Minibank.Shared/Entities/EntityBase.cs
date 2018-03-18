using System;
using FluentValidator;

namespace SP.Minibank.Shared.Entities
{
    public abstract class EntityBase : Notifiable
    {
        
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}