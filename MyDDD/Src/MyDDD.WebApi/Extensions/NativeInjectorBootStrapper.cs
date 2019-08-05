using Microsoft.Extensions.DependencyInjection;
using MyDDD.Application.Interfaces;
using MyDDD.Application.Services;
using MyDDD.Domain.Interfaces;
using MyDDD.Infrastructure.Context;
using MyDDD.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDDD.WebApi.Extensions
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IStudentAppService, StudentAppService>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<StudyContext>();//上下文
        }
    }
}
