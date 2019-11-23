using System;
using System.Collections.Generic;

namespace Wallet.Data.Entities
{
    public class Account : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid TypeId { get; set; }

        public virtual AccountType Type { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }

        public double InitialBalance { get; set; }

        public byte[] Icon { get; set; }

        public string Color { get; set; }

        public double Balance { get; set; }

        public virtual IEnumerable<Record> Records { get; set; }
    }
}