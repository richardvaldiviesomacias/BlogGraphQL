using BlogGraphQL.Services;
using BlogGraphQL.Services.Mapping;
using Microsoft.Extensions.DependencyInjection;

namespace BlogGraphQL
{
    public static class DependencyInjectionContainer
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IUserService, UserService>();
            return services;
        }
    }
}