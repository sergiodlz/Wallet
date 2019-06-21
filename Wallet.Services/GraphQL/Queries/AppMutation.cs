using GraphQL;
using GraphQL.Types;
using System;
using Wallet.Data;
using Wallet.Data.Entities;
using Wallet.Services.Core;
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
                resolve: context =>
                {
                    User user = context.GetArgument<User>("user");
                    string userBy = context.GetArgument<string>("userBy");

                    return _userService.CreateAsync(user, userBy);
                }
            );

            Field<UserGQL>(
                "updateUser",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<UserMGQL>> { Name = "user" },
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "userBy" }),
                resolve: context =>
                {
                    User user = context.GetArgument<User>("user");
                    string userBy = context.GetArgument<string>("userBy");

                    User dbUser = _userService.GetByIdAsync(user.Id).Result;
                    if (dbUser == null)
                    {
                        context.Errors.Add(new ExecutionError("Couldn't find user in db."));
                        return null;
                    }

                    dbUser.Name = user.Name;
                    dbUser.Email = user.Email;
                    dbUser.Password = user.Password;
                    return _userService.UpdateAsync(dbUser, userBy);
                }
            );
        }
    }
}