using System;
using System.ComponentModel.DataAnnotations;

namespace Wallet.Services.ViewModels
{
    public class BaseEntityVM
    {
        public Guid Id { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public string LastMdifiedBy { get; set; }
    }
}