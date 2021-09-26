using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1.Helpers
{
    class CarWeightComparer : IComparer
    {
        public int Compare(object obj1, object obj2)
        {
            var car1 = obj1 as Car;
            var car2 = obj2 as Car;

            if (car1.Weight > car2.Weight)
            {
                return 1;
            }
            else if (car1.Weight < car2.Weight)
            {
                return -1;
            }

            return 0;
        }
    }
}
