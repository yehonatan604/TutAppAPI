using TutApp.Core.Exceptions;
using TutApp.Core.DTOs;
using Newtonsoft.Json;
using System.Net;

namespace TutApp.Api.Controllers
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";

            context.Response.StatusCode = (int)(ex switch
            {
                NotFoundException => HttpStatusCode.NotFound,
                BadRequestException => HttpStatusCode.BadRequest,
                UnauthorizedException => HttpStatusCode.Unauthorized,
                _ => HttpStatusCode.InternalServerError
            });

            ErrorDetailsDTO errorDetails = new(ex.Message, ex.GetType().Name);
            return context.Response.WriteAsync(JsonConvert.SerializeObject(errorDetails));
        }
    }
}
