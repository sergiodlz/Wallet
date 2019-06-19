using GraphQL.Types;
using Wallet.Data.Entities;

namespace Wallet.Services.GraphQL.Types
{
    public class LabelGQL : ObjectGraphType<Label>
    {
        public LabelGQL()
        {
            Field(x => x.Id, type: typeof(IdGraphType));
            Field(x => x.CreatedBy);
            Field(x => x.CreationDate);
            Field(x => x.Enable);
            Field(x => x.LastMdifiedBy);
            Field(x => x.ModificationDate);

            Field(x => x.Name);
        }
    }
}