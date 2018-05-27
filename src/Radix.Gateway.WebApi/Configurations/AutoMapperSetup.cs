using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Radix.Gateway.Client.AutoMapper;
using System;

namespace Radix.Gateway.WebApi.Configurations
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper();

            AutoMapperConfig.RegisterMappings();
        }
    }
}