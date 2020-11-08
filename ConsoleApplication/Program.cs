using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WurmCookingHelper.Data;

namespace WurmCookingHelper.ConsoleApplication
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Development.json", true)
                .Build();

            var services = new ServiceCollection();
            RegisterServices(services, configuration);

            var serviceProvider = services.BuildServiceProvider();
            var application = serviceProvider.GetRequiredService<Application>();
            await application.Run();
        }

        private static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            //services.Configure<AppSettings>(configuration);

            //services.AddTransient<PowerBIService>();
            services.AddTransient<Application>();

            services.AddTransient<IRepository, Repository>();

            //services.Scan(scan => scan
            //    .FromAssemblyOf<Program>()
            //    .AddClasses(classes => classes.AssignableTo<ICommand>())
            //    .AsSelf()
            //    .AsImplementedInterfaces()
            //    .WithTransientLifetime());
        }
    }
}
