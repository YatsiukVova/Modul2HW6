using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1.Providers.Abstractions
{
    interface ICarProvider
    {
        public Car[] Cars { get; }
    }
}
