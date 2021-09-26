using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using ConsoleApp1.Services.Abstractions;

namespace ConsoleApp1.Services
{
    class SortService : ISortService
    {
        public void SortByWeight(Car[] car, IComparer comparer)
        {
            Array.Sort(car, comparer);
        }
    }
}
