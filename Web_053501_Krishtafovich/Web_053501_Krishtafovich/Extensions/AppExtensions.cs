using Web_053501_Krishtafovich.Middleware;
using Microsoft.AspNetCore.Builder;

namespace Web_053501_Krishtafovich.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app) => app.UseMiddleware<LogMiddleware>();
    }
}
