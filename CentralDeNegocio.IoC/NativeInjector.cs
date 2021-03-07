using CentralDeNegocio.Application.Interfaces;
using CentralDeNegocio.Application.Services;
using CentralDeNegocio.Data.Repositories;
using CentralDeNegocio.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CentralDeNegocio.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IClientService, ClientService>();

            #endregion

            #region Repositories

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();

            #endregion
        }
    }
}
