using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Wallet.Data.Configurations.Core;
using Wallet.Data.Entities;

namespace Wallet.Data.Configurations
{
    public class RecordTypeConfiguration : BaseEntityMap<RecordType>
    {
        public RecordTypeConfiguration(string TableName, string IdName) : base(TableName, IdName)
        {
        }

        protected override void InternalMap(EntityTypeBuilder<RecordType> builder)
        {
            builder
                .Property(x => x.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(255);
        }
    }
}