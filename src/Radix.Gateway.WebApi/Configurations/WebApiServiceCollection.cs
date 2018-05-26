using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Radix.Gateway.WebApi.Configurations
{
    public static class WebApiServiceCollectionExtensions
    {
        public static IMvcBuilder AddWebApi(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            var builder = services.AddMvcCore();
            builder.AddJsonFormatters();
            builder.AddCors(opt =>
            {
                opt.AddPolicy("AllowAnyOrigin",
                    configurePolicy => configurePolicy.AllowAnyOrigin());
            });

            return new MvcBuilder(builder.Services, builder.PartManager);
        }
    }
}