using webApi.Middlewares;

namespace webApi.Middlewares
{
    public class TimeMiddleware
    {
        readonly RequestDelegate next;

        public TimeMiddleware(RequestDelegate nextReques)
        {
            next = nextReques;
        }

        public async Task Invoke (HttpContext context)
        {
            await next(context);
            if(context.Request.Query.Any ( p => p.Key == "time")){
                await context.Response.WriteAsync(DateTime.Now.ToShortTimeString());
            }
        }
    }

    
}
public static class TimeMiddlewareExtension
 {
   public static IApplicationBuilder UseTimeMiddleware(this IApplicationBuilder builder)
   {
      return builder.UseMiddleware<TimeMiddleware>();
   }
 }