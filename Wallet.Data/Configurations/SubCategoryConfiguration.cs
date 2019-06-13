using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wallet.Data.Configurations.Core;
using Wallet.Data.Entities;

namespace Wallet.Data.Configurations
{
    public class SubCategoryConfiguration : BaseEntityMap<SubCategory>
    {
        public SubCategoryConfiguration(string TableName, string IdName) : base(TableName, IdName) { }

        protected override void InternalMap(EntityTypeBuilder<SubCategory> builder)
        {
            builder
                .Property(x => x.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);

            builder
                .Property(x => x.CategoryId)
                .IsRequired();
        }
    }
}