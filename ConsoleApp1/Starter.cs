using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.Extensions.DependencyInjection;
using ConsoleApp1.Services.Abstractions;
using ConsoleApp1.Services;
using ConsoleApp1.Providers.Abstractions;
using ConsoleApp1.Providers;
using ConsoleApp1.Helpers;

namespace ConsoleApp1
{
    class Starter
    {
        private Application _application;

        public void StartApplication()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<ITaxiService, TaxiService>()
                .AddTransient<ISortService, SortService>()
                .AddTransient<ICarProvider, CarProvider>()
                .AddTransient<IComparer, Comparer>()
                .AddTransient<Application>()
                .BuildServiceProvider();

            _application = serviceProvider.GetService<Application>();
            _application.Run();
        }
    }
}
