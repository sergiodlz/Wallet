using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wallet.Data.Configurations.Core;
using Wallet.Data.Entities;

namespace Wallet.Data.Configurations
{
    public class CategoryConfiguration : BaseEntityMap<Category>
    {
        public CategoryConfiguration(string TableName, string IdName) : base(TableName, IdName) { }

        protected override void InternalMap(EntityTypeBuilder<Category> builder)
        {
            builder
                .Property(x => x.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);

            builder
                .HasMany(x => x.SubCategories)
                .WithOne()
                .HasForeignKey(c => c.CategoryId);
        }
    }
}
