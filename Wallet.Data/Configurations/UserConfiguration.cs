using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wallet.Data.Configurations.Core;
using Wallet.Data.Entities;

namespace Wallet.Data.Configurations
{
    public class UserConfiguration : BaseEntityMap<User>
    {
        public UserConfiguration(string TableName, string IdName) : base(TableName, IdName) { }

        protected override void InternalMap(EntityTypeBuilder<User> builder)
        {
            builder
               .Property(x => x.Name)
               .IsRequired()
               .IsUnicode()
               .HasMaxLength(255);

            builder
                .Property(x => x.Email)
                .IsUnicode()
                .HasMaxLength(1000);

            builder
                .Property(x => x.Password)
                .IsUnicode()
                .HasMaxLength(1000);

            builder
               .Property(x => x.UserName)
               .IsRequired()
               .IsUnicode()
               .HasMaxLength(50);
        }
    }
}