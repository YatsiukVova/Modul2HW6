using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ConsoleApp1.Services.Abstractions;
using ConsoleApp1.Helpers;
using ConsoleApp1.Extensions;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class Application
    {
        private readonly ITaxiService _taxiService;
        private readonly ISortService _sortService;
        private readonly IComparer _carWeightComparer;

        public Application(ITaxiService taxiService, ISortService sortService)
        {
            _sortService = sortService;
            _taxiService = taxiService;
            _carWeightComparer = new CarWeightComparer();
        }

        public void Run()
        {
            _taxiService.SetRandomCar(10);

        }   
    }
}
