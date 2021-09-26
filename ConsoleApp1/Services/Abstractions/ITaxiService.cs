using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using ConsoleApp1.Services.Abstractions;

namespace ConsoleApp1.Services.Abstractions
{
    interface ITaxiService
    {
        public bool SetRandomCar(int a);
    }
}
