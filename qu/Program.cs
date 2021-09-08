using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace qu
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                    {
                        config
                            .SetBasePath(context.HostingEnvironment.ContentRootPath)
                            .AddJsonFile("appsettings.json", true, true)
                            .AddJsonFile($"appsettings.{context.HostingEnvironment.EnvironmentName}.json", true, true)
                            .AddEnvironmentVariables();

                        var configRoot = config.Build();

                        configRoot.Reload();
                    })
                .UseStartup<Startup>()
                .ConfigureLogging(logging =>
                    {
                        logging.ClearProviders();
                        logging.SetMinimumLevel(LogLevel.Trace);
                    })
                .UseNLog();
    }
}
