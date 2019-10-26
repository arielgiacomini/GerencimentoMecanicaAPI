using Microsoft.Extensions.DependencyInjection;
using SGMLoquinho.ApplicationServices.Services;
using SGMLoquinho.Infrastructure.Context;
using SGMLoquinho.Infrastructure.Repositories.Repository;

namespace SGMLoquinho.CrossCutting
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Services
            services.AddScoped<ApplicationServices.Interfaces.IClienteServices, ClienteServices>();

            //Repositories
            services.AddScoped<Infrastructure.Repositories.Interfaces.IClienteRepository, ClienteRepository>();

            //Infrastructure
            services.AddScoped<SGMLoquinhoContext>();
        }
    }
}
