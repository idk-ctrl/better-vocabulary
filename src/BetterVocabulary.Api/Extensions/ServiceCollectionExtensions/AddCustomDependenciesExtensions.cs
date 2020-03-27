using BetterVocabulary.Application.Services.Base;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BetterVocabulary.Infrastructure;

namespace BetterVocabulary.Api.Extensions.ServiceCollectionExtensions
{
    public static class AddCustomDependenciesExtensions
    {
        public static IServiceCollection
            AddCustomDependencies(this IServiceCollection services, IConfiguration cfg)
        {
            services
                .AddTransient(typeof(IRepository), typeof(Repository));
            return services;
        }
    }
}