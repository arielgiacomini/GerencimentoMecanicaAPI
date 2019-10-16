using Microsoft.Extensions.DependencyInjection;
using SGMLoquinho.ApplicationServices.Interfaces;
using SGMLoquinho.ApplicationServices.Services;
using SGMLoquinho.Domain.ValueObjects;
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

            //Repositories
            services.AddScoped<IClienteRepository, ClienteRepository>();

            //Domain
            services.AddScoped<ConnectionStrings>();

            //Infrastructure
            services.AddScoped<SGMLoquinhoContext>();
        }
    }
}
