using GraphQL.Types;
using Wallet.Data.Entities;
using Wallet.Services.Core;
using Wallet.Services.Extensions;
using Wallet.Services.GraphQL.MutationsTypes;
using Wallet.Services.GraphQL.Types;

namespace Wallet.Services.GraphQL.Queries
{
    public class AppMutation : ObjectGraphType
    {
        public AppMutation(IEntityService<User> _userService)
        {
            Field<UserGQL>(
                "createUser",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<UserMGQL>> { Name = "user" },
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "userBy" }),
                resolve: context => _userService.CreateUserGQL(context)
            );

            Field<UserGQL>(
                "updateUser",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<UserMGQL>> { Name = "user" },
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "userBy" }),
                resolve: context => _userService.UpdateUserGQL(context)
            );
        }
    }
}