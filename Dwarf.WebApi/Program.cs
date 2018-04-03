using Dwarf.Database;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Dwarf.WebApi
{
    class Program
    {
        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                    .UseStartup<Startup>()
                    .UseDefaultServiceProvider(options =>
                    {
                        options.ValidateScopes = false;
                    })
                    .Build();
        }

        static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<DwarfContext>();

                DwarfInitializer.Initialize(context);
            }

            host.Run();
        }
    }
}
