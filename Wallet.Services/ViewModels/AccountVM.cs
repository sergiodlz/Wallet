using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Wallet.Services.Attributes;

namespace Wallet.Services.ViewModels
{
    public class AccountVM : BaseEntityVM
    {
        [Required]
        [StringLength(maximumLength: 250, MinimumLength = 5)]
        public string Name { get; set; }

        [StringLength(maximumLength: 950)]
        public string Description { get; set; }

        [Required]
        [NotEmpty]
        public Guid TypeId { get; set; }

        public string Type { get; set; }

        [Required]
        [NotEmpty]
        public Guid UserId { get; set; }

        public double InitialBalance { get; set; }

        public byte[] Icon { get; set; }

        public string Color { get; set; }

        public IEnumerable<RecordVM> Records { get; set; }
    }
}