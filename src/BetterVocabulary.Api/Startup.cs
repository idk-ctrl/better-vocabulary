using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetterVocabulary.Api.Extensions.AppBuilderExtensions;
using BetterVocabulary.Api.Extensions.ServiceCollectionExtensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BetterVocabulary.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        public void ConfigureServices(IServiceCollection services) =>
            services
                .AddCustomDependencies(_configuration)
                .AddCustomControllers();
        public void Configure(IApplicationBuilder application) =>
            application
                .UseCustomException(_environment)
                .UseHttpsRedirection()
                .UseRouting()
                .UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
}