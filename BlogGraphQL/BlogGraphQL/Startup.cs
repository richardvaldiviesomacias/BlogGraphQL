using System;
using BlogGraphQL.Services;
using BlogGraphQL.Services.Mapping;
using Microsoft.Extensions.DependencyInjection;

namespace BlogGraphQL
{
    public static class Startup
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static IServiceProvider InitializeServices()
        {
            var serviceProvider = new ServiceCollection()
                .ConfigureServices()
                .BuildServiceProvider();
            ServiceProvider = serviceProvider;
            return serviceProvider;
        }
   
    }
}