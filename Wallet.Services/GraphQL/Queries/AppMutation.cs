using GraphQL.Types;
using Wallet.Data;
using Wallet.Data.Entities;
using Wallet.Services.Core;
using Wallet.Services.GraphQL.MutationsTypes;
using Wallet.Services.GraphQL.Types;

namespace Wallet.Services.GraphQL.Queries
{
    public class AppMutation : ObjectGraphType
    {
        public AppMutation(IEntityService<User> _userService, WalletContext _context)
        {
            Field<UserGQL>(
                "createUser",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<UserMGQL>> { Name = "user" },
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "userBy" }),
                resolve: context =>
                {
                    User user = context.GetArgument<User>("user");
                    string userBy = context.GetArgument<string>("userBy");

                    return _userService.CreateAsync(user, userBy);
                }
            );
        }
    }
}