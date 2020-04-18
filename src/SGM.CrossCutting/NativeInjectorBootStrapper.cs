﻿using Microsoft.Extensions.DependencyInjection;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.Services;
using SGM.Infrastructure.Context;
using SGM.Infrastructure.Repositories.Interfaces;
using SGM.Infrastructure.Repositories.Repository;

namespace SGM.CrossCutting
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Services
            services.AddScoped<IClienteServices, ClienteServices>();
            services.AddScoped<IColaboradorServices, ColaboradorServices>();
            services.AddScoped<IOrcamentoServices, OrcamentoServices>();
            services.AddScoped<IPecaServices, PecaServices>();
            services.AddScoped<IMaodeObraServices, MaodeObraServices>();
            //Repositories
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
            services.AddScoped<IOrcamentoRepository, OrcamentoRepository>();
            services.AddScoped<IMaodeObraRepository, MaodeObraRepository>();
            services.AddScoped<IPecaRepository, PecaRepository>();
            //Infrastructure
            services.AddScoped<SGMContext>();
        }
    }
}
