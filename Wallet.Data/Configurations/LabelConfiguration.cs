using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wallet.Data.Entities;

namespace Wallet.Data.Configurations.Core
{
    public class LabelConfiguration : BaseEntityMap<Label>
    {
        public LabelConfiguration(string TableName, string IdName) : base(TableName, IdName) { }

        protected override void InternalMap(EntityTypeBuilder<Label> builder)
        {
            builder
                .Property(x => x.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);
        }
    }
}