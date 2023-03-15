using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace MiddlewarePractices.Middlewares
{
    public class HelloMiddleWare
    {
        private readonly RequestDelegate _next;
        public HelloMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("Hello world");
            await _next.Invoke(context);
            Console.WriteLine("bye world");
        }

    }
    static public class HelloMiddlewareExtension
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HelloMiddleWare>();
        }
    }

    //public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    //{
    //    app.UseHello();

    //    app.Run(async context => await context.Response.WriteAsync("Run middleware"));
    //}

}
