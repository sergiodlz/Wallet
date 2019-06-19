using GraphQL.Types;
using Wallet.Data.Entities;

namespace Wallet.Services.GraphQL.Types
{
    public class AccountTypeGQL : ObjectGraphType<AccountType>
    {
        public AccountTypeGQL()
        {
            Field(x => x.Id, type: typeof(IdGraphType));
            Field(x => x.CreatedBy);
            Field(x => x.CreationDate);
            Field(x => x.Enable);
            Field(x => x.LastMdifiedBy);
            Field(x => x.ModificationDate);

            Field(x => x.Description);
            Field(x => x.Name);
        }
    }
}