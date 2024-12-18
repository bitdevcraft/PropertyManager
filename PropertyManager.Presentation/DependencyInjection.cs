using Microsoft.Extensions.DependencyInjection;

namespace PropertyManager.Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentationDiServices(this IServiceCollection services)
    {
        services
            .AddControllers()
            .AddApplicationPart(PropertyManager.Presentation.AssemblyReference.Assembly);
        return services;
    }
}
