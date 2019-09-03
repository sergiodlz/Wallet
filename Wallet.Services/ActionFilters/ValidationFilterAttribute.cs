using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Threading.Tasks;
using Wallet.Data.Entities;

namespace Wallet.Services.ActionFilters
{
    public class ValidationFilterAttribute : IAsyncActionFilter
    {
        public void ValidateAttribute(ActionExecutingContext context)
        {
            var param = context.ActionArguments.SingleOrDefault(p => p.Value is BaseEntity);
            if (param.Value == null)
            {
                context.Result = new BadRequestObjectResult("Object is null");
            }

            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            ValidateAttribute(context);
            await next();
        }
    }
}