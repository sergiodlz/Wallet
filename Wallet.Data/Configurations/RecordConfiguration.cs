using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wallet.Data.Configurations.Core;
using Wallet.Data.Entities;

namespace Wallet.Data.Configurations
{
    public class RecordConfiguration : BaseEntityMap<Record>
    {
        public RecordConfiguration(string TableName, string IdName) : base(TableName, IdName) { }

        protected override void InternalMap(EntityTypeBuilder<Record> builder)
        {
            builder
                .Property(x => x.Date)
                .IsRequired();

            builder
                .Property(x => x.Description)
                .IsUnicode()
                .HasMaxLength(1000);

            builder
                .Property(x => x.Amount)
                .IsRequired();

            builder
                .Property(x => x.TypeId)
                .IsRequired();

            builder
                .HasOne(x => x.Type)
                .WithMany()
                .HasForeignKey(x => x.TypeId);

            builder
                .Property(x => x.SubCategoryId)
                .IsRequired();

            builder
                .HasOne(x => x.SubCategory)
                .WithMany()
                .HasForeignKey(x => x.SubCategoryId);

            builder
                .Property(x => x.AccountId)
                .IsRequired();

            builder
                .HasOne<Account>()
                .WithMany(a => a.Records)
                .HasForeignKey(x => x.AccountId);
        }
    }
}