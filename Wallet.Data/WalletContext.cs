using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Wallet.Data.Configurations;

namespace Wallet.Data
{
    public class WalletContext : DbContext
    {
        public WalletContext(DbContextOptions<WalletContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AccountTypeConfiguration("AccountType", "AccountTypeId").Map(modelBuilder);
            new AccountConfiguration("Account", "AccountId").Map(modelBuilder);
            new CategoryConfiguration("Category", "CategoryId").Map(modelBuilder);
            new LabelConfiguration("Label", "LabelId").Map(modelBuilder);
            new RecordConfiguration("Record", "RecordId").Map(modelBuilder);
            new RecordTypeConfiguration("RecordType", "RecordTypeId").Map(modelBuilder);
            new SubCategoryConfiguration("SubCategory", "SubCategoryId").Map(modelBuilder);
            new UserConfiguration("User", "UserId").Map(modelBuilder);
            new RecordLabelConfiguration("RecordLabel", "").Map(modelBuilder);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}