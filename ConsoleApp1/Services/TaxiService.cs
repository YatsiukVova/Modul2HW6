using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using ConsoleApp1.Services.Abstractions;
using ConsoleApp1.Providers.Abstractions;

namespace ConsoleApp1.Services
{
    class TaxiService : ITaxiService
    {

        private readonly ICarProvider _carProvider;

        public TaxiService(ICarProvider carProvider)
        {
            _carProvider = carProvider;
        }

        public bool SetRandomCar( int a)
        {
            var random = new Random();
            var cars = _carProvider.Cars;
            for (var i = 0; i < amount; i++)
                {
                    cageService.Add(cars[random.Next(0, cars.Length)]);
                }
            return true;
          
        }
    }
}
