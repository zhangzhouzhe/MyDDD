
using Microsoft.Extensions.DependencyInjection;
using MyDDD.Application.AutoMappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDDD.WebApi.Extensions
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null)
                throw new Exception();
            services.AddAutoMapperSetup();
            AutoMapperConfig.RegisterMappings();
        }
    }
}
