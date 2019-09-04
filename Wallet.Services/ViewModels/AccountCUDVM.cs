using System;
using System.ComponentModel.DataAnnotations;

namespace Wallet.Services.ViewModels
{
    public class AccountCUDVM : BaseEntityVM
    {
        [Required]
        [StringLength(maximumLength:250, MinimumLength = 5)]
        public string Name { get; set; }

        [StringLength(maximumLength: 950)]
        public string Description { get; set; }

        [Required]
        public Guid TypeId { get; set; }

        public string Type { get; set; }

        [Required]
        public Guid UserId { get; set; }

        public double InitialBalance { get; set; } = 0;

        public byte[] Icon { get; set; }

        public string Color { get; set; }
    }
}