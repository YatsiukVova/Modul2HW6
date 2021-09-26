using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Car
{
    public abstract class Sedan : Car
    {
        public override bool IsHasRoof => true;
        public abstract bool CarPremium { get; }
    }
}
