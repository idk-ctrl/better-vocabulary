using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BetterVocabulary.Application.Services.Base;

namespace BetterVocabulary.Infrastructure
{
    public static class DependencyRegistrar
    {
        public static IServiceCollection RegisterDependencies(IServiceCollection services, IConfiguration cfg)
        {
            services
                .AddTransient(typeof(IRepository), typeof(Repository));
            return services;
        }
    }
}
