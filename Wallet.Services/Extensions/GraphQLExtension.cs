using GraphQL;
using GraphQL.Types;
using System;
using System.Threading.Tasks;
using Wallet.Data.Entities;
using Wallet.Services.Core;

namespace Wallet.Services.Extensions
{
    public static class GraphQLExtension
    {
        /// <summary>
        /// Create entity using GraphQL mutation
        /// </summary>
        /// <param name="_entityService">Generic entity repository</param>
        /// <param name="context">GraphQL context</param>
        /// <param name="graphParameter">GraphQL parameter</param>
        /// <returns>entity created</returns>
        public static async Task<T> CreateEntityGQL<T>(
            this IEntityService<T> _entityService,
            ResolveFieldContext<object> context, string graphParameter) where T : BaseEntity
        {
            T entity = context.GetArgument<T>(graphParameter);
            string userBy = context.GetArgument<string>("userBy");

            if (entity == null)
            {
                context.Errors.Add(new ExecutionError("Entity to create empty."));
                return null;
            }

            entity.CreationDate = entity.ModificationDate = DateTime.UtcNow;
            entity.Enable = true;
            entity.LastMdifiedBy = entity.CreatedBy = userBy;
            return await _entityService.CreateAsync(entity);
        }
    }
}