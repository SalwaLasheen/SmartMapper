﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace DTOs
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }


    }
}
