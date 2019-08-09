using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;
using Wallet.Data.Entities;
using Wallet.Services.Core;

namespace Wallet.Services.ActionFilters
{
    public class ValidateEntityExistsAsync<T> : IAsyncActionFilter where T : BaseEntity
    {
        private readonly IEntityService<T> _entityService;

        public ValidateEntityExistsAsync(IEntityService<T> entityService)
        {
            _entityService = entityService;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await ValidateEntityExists(context);
            await next();
        }

        public async Task ValidateEntityExists(ActionExecutingContext context)
        {
            Guid id;
            if (context.ActionArguments.ContainsKey("id"))
            {
                if (!Guid.TryParse(context.ActionArguments["id"].ToString(), out id))
                {
                    context.Result = new BadRequestObjectResult("Bad id parameter");
                    return;
                }
            }
            else
            {
                context.Result = new BadRequestObjectResult("Bad id parameter");
                return;
            }

            var entity = await _entityService.GetByIdAsync(id);
            if (entity == null)
            {
                context.Result = new NotFoundResult();
            }
            else
            {
                context.HttpContext.Items.Add("entity", entity);
            }
        }
    }
}