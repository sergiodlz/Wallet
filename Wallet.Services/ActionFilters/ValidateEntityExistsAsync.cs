using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Wallet.Data.Entities;
using Wallet.Services.Core;

namespace Wallet.Services.ActionFilters
{
    public class ValidateEntityExistsAsync<T> : IAsyncActionFilter where T : BaseEntity
    {
        private readonly IEntityService<T> _entityService;
        private readonly ILogger<ValidateEntityExistsAsync<T>> _logger;

        public ValidateEntityExistsAsync(IEntityService<T> entityService, ILogger<ValidateEntityExistsAsync<T>> logger)
        {
            _entityService = entityService;
            _logger = logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if(await ValidateEntityExists(context))
            {
                await next();
            }            
        }

        public async Task<bool> ValidateEntityExists(ActionExecutingContext context)
        {
            Guid id;
            if (context.ActionArguments.ContainsKey("id"))
            {
                if (!Guid.TryParse(context.ActionArguments["id"].ToString(), out id))
                {
                    context.Result = new BadRequestObjectResult("Bad id parameter");
                    _logger.LogInformation($"Bad id parameter: {context.ActionArguments["id"].ToString()}");
                    return false;
                }
            }
            else
            {
                context.Result = new BadRequestObjectResult("Bad id parameter");
                _logger.LogInformation($"Empty id parameter: {context.ActionArguments["id"].ToString()}");
                return false;
            }

            var entity = await _entityService.GetByIdAsync(id);
            if (entity == null)
            {
                context.Result = new NotFoundResult();
                _logger.LogInformation($"Entity with id: {id} does not exist");
                return false;
            }
            else
            {
                context.HttpContext.Items.Add("entity", entity);
                return true;
            }
        }
    }
}