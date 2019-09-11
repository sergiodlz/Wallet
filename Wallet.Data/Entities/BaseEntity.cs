using System;

namespace Wallet.Data.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public bool Enable { get; set; } = true;
    }
}