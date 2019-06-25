using GraphQL.Types;
using Wallet.Data.Entities;
using Wallet.Services.Core;
using Wallet.Services.GraphQL.Extensions;
using Wallet.Services.GraphQL.MutationsTypes;
using Wallet.Services.GraphQL.Types;

namespace Wallet.Services.GraphQL.Queries
{
    public class AppMutation : ObjectGraphType
    {
        public AppMutation(IEntityService<User> _userService,
            IEntityService<Record> _recordService)
        {
            #region User

            Field<UserGQL>(
                "createUser",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<UserMGQL>> { Name = "user" },
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "userBy" }),
                resolve: context => _userService.CreateEntityGQL(context, "user")
            );

            Field<UserGQL>(
                "updateUser",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<UserMGQL>> { Name = "user" },
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "userBy" }),
                resolve: context => _userService.UpdateUserGQL(context)
            );

            #endregion User

            #region Record

            Field<RecordGQL>(
                "createRecord",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<RecordMGQL>> { Name = "record" },
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "userBy" }),
                resolve: context => _recordService.CreateEntityGQL(context, "record")
            );

            #endregion Record
        }
    }
}