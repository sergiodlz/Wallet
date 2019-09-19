using System;
using System.ComponentModel.DataAnnotations;
using Wallet.Services.Attributes;

namespace Wallet.Services.ViewModels
{
    public class RecordVM : BaseEntityVM
    {
        [Required]
        [NotDefault]
        public DateTime Date { get; set; }

        [StringLength(maximumLength: 950)]
        public string Description { get; set; }

        [Required]
        [NotDefault]
        public double Amount { get; set; }

        [Required]
        [NotDefault]
        public Guid TypeId { get; set; }

        public string Type { get; set; }

        [Required]
        [NotDefault]
        public Guid SubCategoryId { get; set; }

        public string SubCategory { get; set; }

        //public IList<RecordLabel> RecordLabels { get; set; }

        [Required]
        [NotDefault]
        public Guid AccountId { get; set; }

        public string Account { get; set; }
    }
}