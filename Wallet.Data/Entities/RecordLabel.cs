using System;

namespace Wallet.Data.Entities
{
    public class RecordLabel
    {
        public Guid RecordId { get; set; }

        public virtual Record Record { get; set; }

        public Guid LabelId { get; set; }

        public virtual Label Label { get; set; }
    }
}
