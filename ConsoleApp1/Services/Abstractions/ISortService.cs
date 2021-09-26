using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1.Services.Abstractions
{
    interface ISortService
    {
        public void SortByWeight(Car[] car, IComparer comparer);
    }
}
