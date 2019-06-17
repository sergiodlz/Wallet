using GraphQL.Types;
using Wallet.Data.Entities;

namespace Wallet.GraphQL.Types
{
    public class AccountType : ObjectGraphType<Account>
    {
        public AccountType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the account object.");
            Field(x => x.Name).Description("Name property from the account object.");
            Field(x => x.Color).Description("Color property from the account object.");
            Field(x => x.CreatedBy).Description("CreatedBy property from the account object.");
            Field(x => x.CreationDate).Description("CreationDate property from the account object.");
            Field(x => x.Description).Description("Description property from the account object.");
            Field(x => x.InitialBalance).Description("InitialBalance property from the account object.");
            Field(x => x.LastMdifiedBy).Description("LastMdifiedBy property from the account object.");
            Field(x => x.ModificationDate).Description("ModificationDate property from the account object.");
            Field(x => x.TypeId).Description("TypeId property from the account object.");
            Field(x => x.UserId).Description("UserId property from the account object.");
        }
    }
}