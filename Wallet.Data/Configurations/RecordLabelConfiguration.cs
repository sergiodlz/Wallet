using Microsoft.EntityFrameworkCore;
using Wallet.Data.Entities;

namespace Wallet.Data.Configurations
{
    public class RecordLabelConfiguration
    {
        private readonly string TableName;
        private readonly string IdName;

        public RecordLabelConfiguration(string TableName, string IdName)
        {
            this.TableName = TableName;
            this.IdName = TableName;
        }

        public void Map(ModelBuilder builder)
        {
            builder.Entity<RecordLabel>()
                .ToTable(TableName);

            builder.Entity<RecordLabel>()
                .HasKey(x => new { x.RecordId, x.LabelId });

            builder.Entity<RecordLabel>()
                .HasOne(x => x.Record)
                .WithMany(x => x.RecordLabels)
                .HasForeignKey(x => x.RecordId);

            builder.Entity<RecordLabel>()
                .HasOne(x => x.Label)
                .WithMany(x => x.RecordLabels)
                .HasForeignKey(x => x.LabelId);
        }
    }
}