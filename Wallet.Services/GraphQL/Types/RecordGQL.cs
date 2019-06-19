using GraphQL.Types;
using Wallet.Data.Entities;

namespace Wallet.Services.GraphQL.Types
{
    public class RecordGQL : ObjectGraphType<Record>
    {
        public RecordGQL()
        {
            Field(x => x.Id, type: typeof(IdGraphType));
            Field(x => x.CreatedBy);
            Field(x => x.CreationDate, type: typeof(DateTimeGraphType));
            Field(x => x.Enable);
            Field(x => x.LastMdifiedBy, type: typeof(StringGraphType));
            Field(x => x.ModificationDate, type: typeof(DateTimeGraphType));

            Field(x => x.AccountId, type: typeof(IdGraphType));
            Field(x => x.Amount);
            Field(x => x.Date, type: typeof(DateTimeGraphType));
            Field(x => x.Description, type: typeof(StringGraphType));
            Field(x => x.SubCategoryId, type: typeof(IdGraphType));
            Field(x => x.TypeId, type: typeof(IdGraphType));
        }
    }
}