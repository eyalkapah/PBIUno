using Microsoft.Extensions.DependencyInjection;
using PBIUno.Shared.Services;
using PBIUno.Shared.ViewModels;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBIUno.Shared
{
    public static class Startup
    {
        internal static void ConfigureServices(ServiceCollection services)
        {
            // Register View Models
            services.AddScoped<MainPageViewModel>();

            services.AddSingleton<INavigationService, NavigationService>();

            services.AddHttpClient("AzureWebSites", client =>
            {
                client.BaseAddress = new Uri("http: //10.0.2.2:5000/");
            })
                .AddTransientHttpErrorPolicy(builder => builder.WaitAndRetryAsync(new[]
                {
                    TimeSpan.FromSeconds(1),
                    TimeSpan.FromSeconds(5),
                    TimeSpan.FromSeconds(10),
                }));

            IoC.SetServiceProvider(services.BuildServiceProvider());
        }
    }
}