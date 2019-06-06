using System;

namespace Wallet.Data.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public bool Enable { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ModificationDate { get; set; }

        public string CreatedBy { get; set; }

        public string LastMdifiedBy { get; set; }
    }
}