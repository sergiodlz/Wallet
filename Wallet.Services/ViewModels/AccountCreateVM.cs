using System;
using System.ComponentModel.DataAnnotations;

namespace Wallet.Services.ViewModels
{
    public class AccountCreateVM : BaseEntityVM
    {
        [Required]
        public string Name { get; set; }

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