using Scrutor;
using PropertyManager.Application;
using PropertyManager.Domain.Entities.Authorizations.Roles;
using PropertyManager.Domain.Entities.Users;
using PropertyManager.Infrastructure;
using PropertyManager.Persistence;
using PropertyManager.Presentation;

namespace PropertyManager.Services.App;

internal static class DependencyInjection
{
    public static IServiceCollection AddAppDiServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddIdentityService();

        services.AddClassLibDependencyInjectionService(configuration);

        services.AddAssemblyService();

        return services;
    }

    /// <summary>
    /// Set up the User and Role
    /// </summary>
    /// <param name="services">self</param>
    /// <returns></returns>
    private static IServiceCollection AddIdentityService(
        this IServiceCollection services
    )
    {
        services.AddSingleton<TimeProvider>(TimeProvider.System);
        services
            .AddIdentityCore<User>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = true;
            })
            .AddRoles<Role>()
            .AddEntityFrameworkStores<AppDbContext>();

        return services;
    }

    /// <summary>
    /// Injecting the Class Libraries' Dependency Injection
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    private static IServiceCollection AddClassLibDependencyInjectionService(this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .AddPersistenceDiServices(configuration)
            .AddApplicationDiServices()
            .AddInfrastructureDiServices()
            .AddPresentationDiServices();
        return services;
    }

    /// <summary>
    /// Adding the Assembly References of the Class Libraries
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    private static IServiceCollection AddAssemblyService(this IServiceCollection services)
    {
        services.Scan(selector =>
            selector
                .FromAssemblies(
                    PropertyManager.Infrastructure.AssemblyReference.Assembly,
                    PropertyManager.Persistence.AssemblyReference.Assembly
                )
                .AddClasses(false)
                .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                .AsImplementedInterfaces()
                .WithScopedLifetime()
        );
        return services;
    }
}
