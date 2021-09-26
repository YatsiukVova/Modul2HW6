using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Car.Sedan
{
   public abstract class EconomClass : Sedan
    {
        public override bool CarPremium => false;
    }
}
