using BuberDinner.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastucture(this IServiceCollection service)
        {
            service.AddScoped<IAuthenticationService, AuthenticationService>();

            return service;
        }
    }
}