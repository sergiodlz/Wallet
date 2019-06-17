using GraphQL.Types;
using Wallet.Data.Entities;

namespace Wallet.GraphQL.Types
{
    public class SubCategoryGQL : ObjectGraphType<SubCategory>
    {
        public SubCategoryGQL()
        {
            Field(x => x.Id, type: typeof(IdGraphType));
            Field(x => x.CreatedBy);
            Field(x => x.CreationDate);
            Field(x => x.Enable);
            Field(x => x.LastMdifiedBy);
            Field(x => x.ModificationDate);

            Field(x => x.CategoryId, type: typeof(IdGraphType));
            Field(x => x.Name);
        }
    }
}