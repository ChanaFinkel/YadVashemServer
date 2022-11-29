using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Threading.Tasks;

namespace Registrant.WebApi.MiddleWres
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class HandleErrorMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly ILogger<HandleErrorMiddleware> _logger;
        public HandleErrorMiddleware(RequestDelegate next, ILogger<HandleErrorMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                var response = httpContext.Response;
                response.ContentType = "application/json";
                HttpStatusCode statusCode = ex switch
                {
                    ArgumentNullException or ArgumentException => HttpStatusCode.BadRequest,
                    _ => HttpStatusCode.InternalServerError,
                };
                response.StatusCode = (int)statusCode;
                await response.WriteAsync(ex.Message);

                _logger.Log(LogLevel.Error, ex.Message, response.StatusCode, ex.StackTrace);
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class HandleErrorMiddlewareExtensions
    {
        public static IApplicationBuilder UseHandleErrorMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HandleErrorMiddleware>();
        }
    }
}
