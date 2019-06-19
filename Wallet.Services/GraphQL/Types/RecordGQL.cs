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
            Field(x => x.CreationDate);
            Field(x => x.Enable);
            Field(x => x.LastMdifiedBy);
            Field(x => x.ModificationDate);

            Field(x => x.AccountId, type: typeof(IdGraphType));
            Field(x => x.Amount);
            Field(x => x.Date);
            Field(x => x.Description);
            Field(x => x.SubCategoryId, type: typeof(IdGraphType));
            Field(x => x.TypeId, type: typeof(IdGraphType));
        }
    }
}