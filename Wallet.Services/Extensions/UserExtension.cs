using GraphQL;
using GraphQL.Types;
using System;
using System.Threading.Tasks;
using Wallet.Data.Entities;
using Wallet.Services.Core;

namespace Wallet.Services.Extensions
{
    public static class UserExtension
    {
        /// <summary>
        /// Create user using GraphQL mutation
        /// </summary>
        /// <param name="_userService">Generic user repository</param>
        /// <param name="context">GraphQL context</param>
        /// <returns>User created</returns>
        public static async Task<User> CreateUserGQL(
            this IEntityService<User> _userService, 
            ResolveFieldContext<object> context)
        {
            User user = context.GetArgument<User>("user");
            string userBy = context.GetArgument<string>("userBy");

            if (user == null)
            {
                context.Errors.Add(new ExecutionError("User to create empty."));
                return null;
            }

            user.CreationDate = user.ModificationDate = DateTime.UtcNow;
            user.Enable = true;
            user.LastMdifiedBy = user.CreatedBy = userBy;
            return await _userService.CreateAsync(user);
        }

        /// <summary>
        /// Update user using GraphQL mutation
        /// </summary>
        /// <param name="_userService">Generic user repository</param>
        /// <param name="context">GraphQL context</param>
        /// <returns>User updated</returns>
        public static async Task<User> UpdateUserGQL(
            this IEntityService<User> _userService, 
            ResolveFieldContext<object> context)
        {
            User user = context.GetArgument<User>("user");
            string userBy = context.GetArgument<string>("userBy");

            if(user == null || user.Id.Equals(Guid.Empty))
            {
                context.Errors.Add(new ExecutionError("User to update or id field empty."));
                return null;
            }

            User dbUser = await _userService.GetByIdAsync(user.Id);
            if (dbUser == null)
            {
                context.Errors.Add(new ExecutionError($"Couldn't find user with id {user.Id}."));
                return null;
            }

            dbUser.Name = user.Name;
            dbUser.Email = user.Email;
            dbUser.Password = user.Password;
            dbUser.ModificationDate = DateTime.UtcNow;
            dbUser.LastMdifiedBy = userBy;

            return await _userService.UpdateAsync(dbUser);
        }
    }
}