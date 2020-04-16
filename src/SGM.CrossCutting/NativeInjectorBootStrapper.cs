using Microsoft.Extensions.DependencyInjection;
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
            //Repositories
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
            services.AddScoped<IOrcamentoRepository, OrcamentoRepository>();
            //Infrastructure
            services.AddScoped<SGMContext>();
        }
    }
}
