using Microsoft.Extensions.DependencyInjection;
using parkareSolution.Application;
using parkareSolution.Domain;
using parkareSolution.Domain.Interfaces;
using System;

namespace parkareSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass[] genericClasses = new GenericClass[] { new ClassA(), new ClassB(), new ClassC(), new ClassD() };
            var services = new ServiceCollection();
            ConfigureServices(services);
            services
                .AddSingleton<Main, Main>()
                .BuildServiceProvider()
                .GetService<Main>()
                .Save(genericClasses);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IRepository<GenericClass>, Repository<GenericClass>>();
        }
    }
}
