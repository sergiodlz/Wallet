using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wallet.Data.Configurations.Core;
using Wallet.Data.Entities;

namespace Wallet.Data.Configurations
{
    public class AccountConfiguration : BaseEntityMap<Account>
    {
        public AccountConfiguration(string TableName, string IdName) : base(TableName, IdName) { }

        protected override void InternalMap(EntityTypeBuilder<Account> builder)
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

            builder
                .Property(x => x.UserId)
                .IsRequired();

            builder
                .HasOne(x => x.User)
                .WithMany(a => a.Accounts)
                .HasForeignKey(x => x.UserId);

            builder
                .Property(x => x.InitialBalance)
                .HasDefaultValueSql("0");

            builder
                .Property(x => x.Balance)
                .HasDefaultValueSql("0");

            builder
                .Property(x => x.TypeId)
                .IsRequired();

            builder
                .Property(x => x.Icon);

            builder
                .Property(x => x.Color)
                .IsUnicode()
                .HasMaxLength(50);

            builder
                .HasOne(x => x.Type)
                .WithMany()
                .HasForeignKey(x => x.TypeId);

            builder
                .HasMany(x => x.Records)
                .WithOne(r => r.Account)
                .HasForeignKey(r => r.AccountId);
        }
    }
}