using System;
using System.Threading.Tasks;
using SimpleSelftCreateIOC.DependencyInjection;
using SimpleSelftCreateIOC.Test;

namespace SimpleSelftCreateIOC
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var services = new DiServiceCollection();
            //services.RegisterSingleton(new RandomGuidGenerator());
            services.RegisterSingleton<IRandomGuidProvider, RandomGuidProvider>();
            services.RegisterTransient<ISomeService,SomServiceOne>();
            services.RegisterSingleton<MainApp>();

            var container = services.GenerateContainer();
            var serviceFirst = container.GetService<ISomeService>();
            var serviceSecond = container.GetService<ISomeService>();
            var mainapp = container.GetService<MainApp>();
           await mainapp.RunAppAsync();
            serviceFirst.WriteMessage();
            serviceSecond.WriteMessage();
        }
    }
}
