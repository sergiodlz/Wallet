using GraphQL.Types;
using Wallet.Data.Entities;

namespace Wallet.GraphQL.Types
{
    public class BaseType : ObjectGraphType<BaseEntity>
    {
        public BaseType()
        {
            Field(x => x.Id, type: typeof(IdGraphType));
            Field(x => x.CreatedBy);
            Field(x => x.CreationDate);
            Field(x => x.Enable);
            Field(x => x.LastMdifiedBy);
            Field(x => x.ModificationDate);
        }
    }
}
