using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;

namespace Radix.Gateway.WebApi.LogManagement
{
    public class UnhandledExceptionManager : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var status = HttpStatusCode.InternalServerError;
            var message = String.Empty;

            var exceptionType = context.Exception.GetType();
            if (exceptionType == typeof(UnauthorizedAccessException))
            {
                message = "Acesso não autorizado.";
                status = HttpStatusCode.Unauthorized;
            }
            else if (exceptionType == typeof(NotImplementedException))
            {
                message = "Ops, ocorreu um erro interno no servidor.";
                status = HttpStatusCode.NotImplemented;
            }
            else
            {
                message = context.Exception.Message;
                status = HttpStatusCode.NotFound;
            }
            context.ExceptionHandled = true;

            var response = context.HttpContext.Response;
            response.StatusCode = (int)status;
            response.ContentType = "application/json";
            var err = message + " " + context.Exception.StackTrace;
            response.WriteAsync(err);
        }
    }
}
