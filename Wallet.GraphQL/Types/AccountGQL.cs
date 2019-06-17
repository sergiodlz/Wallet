using GraphQL.Types;
using Wallet.Data.Entities;

namespace Wallet.GraphQL.Types
{
    public class AccountGQL : ObjectGraphType<Account>
    {
        public AccountGQL()
        {
            Field(x => x.Id, type: typeof(IdGraphType));
            Field(x => x.CreatedBy);
            Field(x => x.CreationDate);
            Field(x => x.Enable);
            Field(x => x.LastMdifiedBy);
            Field(x => x.ModificationDate);

            Field(x => x.Name).Description("Name property from the account object.");
            Field(x => x.Color).Description("Color property from the account object.");
            Field(x => x.Description).Description("Description property from the account object.");
            Field(x => x.InitialBalance).Description("InitialBalance property from the account object.");
            Field(x => x.TypeId, type: typeof(IdGraphType)).Description("TypeId property from the account object.");
            Field(x => x.UserId, type: typeof(IdGraphType)).Description("UserId property from the account object.");
        }
    }
}