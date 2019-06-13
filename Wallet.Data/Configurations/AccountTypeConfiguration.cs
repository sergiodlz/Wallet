using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wallet.Data.Configurations.Core;
using Wallet.Data.Entities;

namespace Wallet.Data.Configurations
{
    public class AccountTypeConfiguration : BaseEntityMap<AccountType>
    {
        public AccountTypeConfiguration(string TableName, string IdName) : base(TableName, IdName) { }

        protected override void InternalMap(EntityTypeBuilder<AccountType> builder)
        {
            builder
                .Property(x => x.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);

            builder
                .Property(x => x.Description)
                .IsUnicode()
                .HasMaxLength(1000);
        }
    }
}