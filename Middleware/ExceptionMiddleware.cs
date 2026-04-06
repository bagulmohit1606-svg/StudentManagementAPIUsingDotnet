using System.Net;
using System.Text.Json;

namespace StudentManagementSystem.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }

        private static Task HandleException(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";

            var response = context.Response;

            response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var result = JsonSerializer.Serialize(new
            {
                statusCode = response.StatusCode,
                message = "Something went wrong!",
                error = ex.Message
            });

            return context.Response.WriteAsync(result);
        }
    }
}