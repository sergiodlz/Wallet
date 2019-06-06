using System;
using System.Collections.Generic;

namespace Wallet.Data.Entities
{
    public class Record : BaseEntity
    {
        public DateTime Date { get; set; }

        public string Description { get; set; }

        public double Amount { get; set; }

        public Guid TypeId { get; set; }

        public virtual RecordType Type { get; set; }

        public virtual IEnumerable<Label> Labels { get; set; }

        public Guid SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }
    }
}