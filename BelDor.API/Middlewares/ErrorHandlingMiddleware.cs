using Core.Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BelDor.API.Middlewares
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate next;
        private readonly IResponse requestResult;
        public ErrorHandlingMiddleware(RequestDelegate next, IResponse requestResult_)
        {
            this.next = next;
            requestResult = requestResult_;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            requestResult.status = false;
            //var exception = context.Exception;
            var code = HttpStatusCode.InternalServerError; // 500 if unexpected
            requestResult.error_EN = JsonConvert.SerializeObject(new { error = ex.Message });
            requestResult.error_AR = requestResult.error_EN;
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            string jsonString = JsonConvert.SerializeObject(requestResult);
            await context.Response.WriteAsync(jsonString, Encoding.UTF8);
        }
    }
}
