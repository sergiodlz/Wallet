using GraphQL.Types;
using Wallet.Data.Entities;
using Wallet.GraphQL.Types;
using Wallet.Services.Core;

namespace Wallet.GraphQL.Queries
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