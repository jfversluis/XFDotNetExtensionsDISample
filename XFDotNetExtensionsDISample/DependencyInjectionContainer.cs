using System;
using Microsoft.Extensions.DependencyInjection;

namespace XFDotNetExtensionsDISample
{
    public static class DependencyInjectionContainer
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IMyService, MyService>();

            return services;
        }

        public static IServiceCollection ConfigureViewModels(this IServiceCollection services)
        {
            services.AddTransient<MainPageModel>();

            return services;
        }
    }
}
