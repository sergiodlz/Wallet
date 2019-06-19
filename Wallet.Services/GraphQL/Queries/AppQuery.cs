using GraphQL.Types;
using Wallet.Data.Entities;
using Wallet.Services.GraphQL.Types;
using Wallet.Services.Core;

namespace Wallet.Services.GraphQL.Queries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IEntityService<Account> repository)
        {
            Field<ListGraphType<AccountGQL>>(
               "accounts",
               resolve: context => repository.GetAllAsync()
           );
        }
    }
}