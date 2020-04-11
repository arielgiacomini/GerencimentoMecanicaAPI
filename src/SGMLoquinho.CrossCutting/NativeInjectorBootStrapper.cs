using Microsoft.Extensions.DependencyInjection;
using SGMLoquinho.ApplicationServices.Interfaces;
using SGMLoquinho.ApplicationServices.Services;
using SGMLoquinho.Infrastructure.Context;
using SGMLoquinho.Infrastructure.Repositories.Interfaces;
using SGMLoquinho.Infrastructure.Repositories.Repository;

namespace SGMLoquinho.CrossCutting
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Services
            services.AddScoped<IClienteServices, ClienteServices>();
            services.AddScoped<IRhColaboradoresServices, RhColaboradoresServices>();
            //Repositories
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();

            //Infrastructure
            services.AddScoped<SGMLoquinhoContext>();
        }
    }
}
