using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BetterVocabulary.Infrastructure
{
    public class DependencyRegistrar
    {
        public static IServiceCollection RegisterDependencies(this IServiceCollection services, IConfiguration cfg)
        {
            services
                .AddDbContext<DbContext, DataContext>(options => ConfigureDbContext(cfg, options))
                .AddTransient(typeof(IRepository<>), typeof(Repository<>))
                .AddTransient<ICreditUnionDataService, CreditUnionDataService>()
                .AddTransient<ILocationsProfilesDataProvider, LocationsProfilesDataProvider>()
                .AddTransient<ICuServicesProviderService, CuServicesProviderService>()
                .AddTransient(typeof(ICachingService<>), typeof(CachingService<>))
                .AddSingleton(AutoMapperConfiguration.RegisterMappings().CreateMapper())
                .AddLogging();
            return services;
        }
    }
}
