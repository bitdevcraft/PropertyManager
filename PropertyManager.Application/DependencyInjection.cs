﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using PropertyManager.Application.Abstraction.Behaviors;

namespace PropertyManager.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationDiServices(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(AssemblyReference.Assembly);

            configuration.AddOpenBehavior(typeof(ValidationBehavior<,>));
        });

        services.AddValidatorsFromAssembly(AssemblyReference.Assembly, includeInternalTypes: true);

        return services;
    }
}