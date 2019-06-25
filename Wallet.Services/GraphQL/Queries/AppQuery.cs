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
                   if (!Guid.TryParse(context.GetArgument<string>("userId"), out Guid id))
                   {
                       context.Errors.Add(new ExecutionError("Wrong value for guid argument"));
                       return null;
                   }

                   return _accountService
                            .FindByConditionAndIncludeAsync(
                                x => x.UserId.Equals(id), 
                                x => x.Type
                            );
               }
            );

            Field<AccountGQL>(
               "account",
               arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
               resolve: context =>
               {
                   if (!Guid.TryParse(context.GetArgument<string>("id"), out Guid id))
                   {
                       context.Errors.Add(new ExecutionError("Wrong value for guid argument"));
                       return null;
                   }

                   return _accountService
                            .GetByIdAndIncludeAsync(id, 
                                x => x.Type, 
                                x => x.Records
                            );
               }
            );

            #endregion

            #region User

            Field<ListGraphType<UserGQL>>(
               "users",
               resolve: context => _userService.GetAllAsync()
            );

            Field<UserGQL>(
               "user",
               arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
               resolve: context =>
               {
                   if (!Guid.TryParse(context.GetArgument<string>("id"), out Guid id))
                   {
                       context.Errors.Add(new ExecutionError("Wrong value for guid argument"));
                       return null;
                   }

                   return _userService.GetByIdAsync(id);
               }
            );

            #endregion
        }
    }
}