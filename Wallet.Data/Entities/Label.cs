using System.Collections.Generic;

namespace Wallet.Data.Entities
{
    public class Label : BaseEntity
    {
        public string Name { get; set; }

        //public virtual IEnumerable<Record> Records { get; set; }

        public IList<RecordLabel> RecordLabels { get; set; }
    }
}