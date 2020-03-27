using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace BetterVocabulary.Api.Extensions.AppBuilderExtensions
{
    public static class UseCustomExceptionExtensions
    {
        public static IApplicationBuilder UseCustomException(this IApplicationBuilder app, IWebHostEnvironment env) =>
            env.IsDevelopment() 
                ? app.UseDeveloperExceptionPage()
                : app;
    }
}