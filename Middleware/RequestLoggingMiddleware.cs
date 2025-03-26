using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ProductAPI.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine($"Request Path: {context.Request.Path}, Method: {context.Request.Method}");
            await _next(context);
        }
    }
}
