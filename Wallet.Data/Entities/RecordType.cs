namespace Wallet.Data.Entities
{
    public class RecordType : BaseEntity
    {
        public string Name { get; set; }

        public bool IsExpense { get; set; }
    }
}