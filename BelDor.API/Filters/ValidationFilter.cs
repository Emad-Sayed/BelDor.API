using Core.Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelDor.API.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        private readonly IResponse response;
        public ValidationFilter(IResponse response_)
        {
            response = response_;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (context.ModelState.IsValid)
                await next();
            response.status = false;
            response.error_EN = String.Join("&&", context.ModelState.Values.SelectMany(e => e.Errors.Select(e => e.ErrorMessage)));
            response.error_AR = response.error_EN;
            context.Result = new BadRequestObjectResult(response);
        }
    }
}
