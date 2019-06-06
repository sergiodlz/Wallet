using System;

namespace Wallet.Data.Entities
{
    public class SubCategory : BaseEntity
    {
        public string Name { get; set; }

        public Guid CategoryId { get; set; }
    }
}