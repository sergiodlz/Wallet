using System;
using System.Collections.Generic;

namespace Wallet.Services.ViewModels
{
    public class AccountVM : BaseEntityVM
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid TypeId { get; set; }

        public string Type { get; set; }

        public Guid UserId { get; set; }

        public double InitialBalance { get; set; }

        public byte[] Icon { get; set; }

        public string Color { get; set; }

        public IEnumerable<RecordVM> Records { get; set; }
    }
}