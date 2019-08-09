using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using Wallet.Data.Entities;
using Wallet.Services.Core;

namespace Wallet.Services.ActionFilters
{
    public class ValidateEntityExistsAttribute<T> : IActionFilter where T : BaseEntity
    {
        private readonly IEntityService<T> _entityService;

        public ValidateEntityExistsAttribute(IEntityService<T> entityService)
        {
            _entityService = entityService;
        }

        public async void OnActionExecuting(ActionExecutingContext context)
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

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}