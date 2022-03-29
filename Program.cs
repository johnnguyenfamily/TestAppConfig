using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Azure.Identity;

namespace TestAppConfig
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        // WITHOUT enabling dynamic configuration
        /*public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                    webBuilder.ConfigureAppConfiguration(config =>
                    {
                        var settings = config.Build();
                        var connection = settings.GetConnectionString("AppConfig");
                        config.AddAzureAppConfiguration(connection);
                    }).UseStartup<Startup>());*/

        // WITH enabling dynamic configuration
        /*public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                    webBuilder.ConfigureAppConfiguration((hostingContext, config) =>
                    {
                        var settings = config.Build();
                        config.AddAzureAppConfiguration(options =>
                        {
                            options.Connect(settings["ConnectionStrings:AppConfig"])
                                   .ConfigureRefresh(refresh =>
                                   {
                                       refresh.Register("TestApp:Settings:Sentinel", refreshAll: true)
                                              .SetCacheExpiration(new TimeSpan(0, 0, 5));
                                   });
                        });
                    })
                .UseStartup<Startup>());*/

        // INTEGRATE with Managed Identity
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                    webBuilder.ConfigureAppConfiguration((hostingContext, config) =>
                    {
                        var settings = config.Build();
                        config.AddAzureAppConfiguration(options =>
                            options.Connect(new Uri(settings["AppConfig:Endpoint"]), new ManagedIdentityCredential())
                                //.ConfigureRefresh(refresh =>
                                //{
                                //    refresh.Register("TestApp:Settings:Sentinel", refreshAll: true)
                                //           .SetCacheExpiration(new TimeSpan(0, 0, 5));
                                //}));
                                .ConfigureKeyVault(kv =>
                                {
                                    kv.SetCredential(new DefaultAzureCredential());
                                }));
                    })
                    .UseStartup<Startup>());
    }
}
