using GraphQL.Types;
using Wallet.Data.Entities;

namespace Wallet.Services.GraphQL.Types
{
    public class AccountGQL : ObjectGraphType<Account>
    {
        public AccountGQL()
        {
            Field(x => x.Id, type: typeof(IdGraphType));
            Field(x => x.CreatedBy);
            Field(x => x.CreationDate, type: typeof(DateTimeGraphType));
            Field(x => x.Enable);
            Field(x => x.LastMdifiedBy, type: typeof(StringGraphType));
            Field(x => x.ModificationDate, type: typeof(DateTimeGraphType));

            Field(x => x.Name).Description("Name property from the account object.");
            Field(x => x.Color, type: typeof(StringGraphType)).Description("Color property from the account object.");
            Field(x => x.Description, type: typeof(StringGraphType)).Description("Description property from the account object.");
            Field(x => x.InitialBalance).Description("InitialBalance property from the account object.");
            Field(x => x.TypeId, type: typeof(IdGraphType)).Description("TypeId property from the account object.");
            Field(x => x.UserId, type: typeof(IdGraphType)).Description("UserId property from the account object.");
            Field<AccountTypeGQL>("Type");
        }
    }
}