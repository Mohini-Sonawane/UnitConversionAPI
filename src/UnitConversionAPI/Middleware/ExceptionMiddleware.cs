using System.Text.Json;

namespace UnitConversionAPI.Middleware
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
            catch(Exception ex)
            {
                context.Response.StatusCode = 400;

                await context.Response.WriteAsync(
                    JsonSerializer.Serialize(new
                    {
                        error=ex.Message
                    }));
            }
        }
    }
}
