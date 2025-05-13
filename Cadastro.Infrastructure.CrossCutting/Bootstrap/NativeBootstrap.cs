using Cadastro.Adapter;
using Cadastro.Application.Interfaces;
using Cadastro.Application.Services;
using Cadastro.Domain.Contracts.Adapters;
using Cadastro.Domain.Contracts.Repositories;
using Cadastro.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Infrastructure.CrossCutting.Bootstrap
{
    public static class NativeBootstrap
    {
        public static void serviceLocation(IServiceCollection services)
        {
            services.AddScoped<ICepAppServices, CepAppServices>();
            services.AddScoped<ICepAdapter, CepAdapter>();

            services.AddScoped<IUserAppServices, UserAppServices>();

            services.AddScoped<IUserRepository, UserRepository>() ;

        }
    }
}
