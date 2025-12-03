using Application.Services;
using Domain.Interfacses.Integrations;
using Domain.Interfacses.Repositories;
using Domain.Interfacses.Services;
using Infrastructure.Integrations;
using Infrastructure.Repositories;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IUserPhoneNumberRepository, UserPhoneNumberRepository>();
            services.AddScoped<IUserPhoneNumberService, UserPhoneNumberService>();
            services.AddTransient<ISmsSender, SmsSender>();

            return services;
        }
    }
} 