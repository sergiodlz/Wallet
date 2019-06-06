using System.Collections.Generic;

namespace Wallet.Data.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public IEnumerable<SubCategory> SubCategories { get; set; }
    }
}