using BetterVocabulary.Api.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace BetterVocabulary.Api.Extensions.ServiceCollectionExtensions
{
    public static class AddCustomControllersExtensions
    {
        public static IMvcBuilder AddCustomControllers(this IServiceCollection services) =>
            services
                .AddControllers(options => RegisterFilters(options.Filters))
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

        private static void RegisterFilters(FilterCollection filters)
        {
            filters.Add<ModelValidationFilter>();
        }
    }
}