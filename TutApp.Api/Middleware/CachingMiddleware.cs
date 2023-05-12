namespace TutApp.Api.Middleware
{
    public class CachingMiddleware
    {
        private readonly RequestDelegate _next;

        public CachingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.GetTypedHeaders().CacheControl =
         new Microsoft.Net.Http.Headers.CacheControlHeaderValue()
         {
             Public = true,
             MaxAge = TimeSpan.FromSeconds(10),
         };

            context.Response.Headers[Microsoft.Net.Http.Headers.HeaderNames.Vary] =
                new string[] { "Accept-Encoding" };

            await _next(context);
        }
    }
}
