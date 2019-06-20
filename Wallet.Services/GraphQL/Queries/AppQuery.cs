using GraphQL;
using GraphQL.Types;
using System;
using Wallet.Data.Entities;
using Wallet.Services.Core;
using Wallet.Services.GraphQL.Types;

namespace Wallet.Services.GraphQL.Queries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IEntityService<Account> _accountService, IEntityService<User> _userService)
        {
            #region Account

            Field<ListGraphType<AccountGQL>>(
               "accounts",
               resolve: context => _accountService.GetAllAndIncludeAsync(x => x.Type)
            );

            Field<ListGraphType<AccountGQL>>(
               "accountsByUserId",
               arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "userId" }),
               resolve: context =>
               {
                   Guid id;
                   if (!Guid.TryParse(context.GetArgument<string>("userId"), out id))
                   {
                       context.Errors.Add(new ExecutionError("Wrong value for guid argument"));
                       return null;
                   }

                   return _accountService.FindByConditionAndIncludeAsync(x => x.UserId.Equals(id), x => x.Type);
               }
            );

            #endregion

            Field<ListGraphType<UserGQL>>(
               "users",
               resolve: context => _userService.GetAllAsync()
            );
        }
    }
}