using GraphQL.Types;
using Wallet.Data.Entities;

namespace Wallet.Services.GraphQL.Types
{
    public class CategoryGQL : ObjectGraphType<Category>
    {
        public CategoryGQL()
        {
            Field(x => x.Id, type: typeof(IdGraphType));
            Field(x => x.CreatedBy);
            Field(x => x.CreationDate, type: typeof(DateTimeGraphType));
            Field(x => x.Enable);
            Field(x => x.LastMdifiedBy, type: typeof(StringGraphType));
            Field(x => x.ModificationDate, type: typeof(DateTimeGraphType));

            Field(x => x.Name);
        }
    }
}