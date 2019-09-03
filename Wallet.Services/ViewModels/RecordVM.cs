using System;
using System.Collections.Generic;

namespace Wallet.Services.ViewModels
{
    public class RecordVM
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public double Amount { get; set; }

        public Guid TypeId { get; set; }

        public string Type { get; set; }

        public Guid SubCategoryId { get; set; }

        public string SubCategory { get; set; }

        //public IList<RecordLabel> RecordLabels { get; set; }

        public Guid AccountId { get; set; }
    }
}