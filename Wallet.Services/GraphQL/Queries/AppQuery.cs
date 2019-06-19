using GraphQL.Types;
using Wallet.Data.Entities;
using Wallet.Services.Core;
using Wallet.Services.GraphQL.Types;

namespace Wallet.Services.GraphQL.Queries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IEntityService<Account> repository)
        {
            Field<ListGraphType<AccountGQL>>(
               "accounts",
               resolve: context => repository.GetAllAndIncludeAsync(x => x.Type)
           );
        }
    }
}