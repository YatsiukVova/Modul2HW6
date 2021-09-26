using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Models.Car.Sedan.PremiumClass
{
   public class BMW : PremiumClass
    {
        public BMWType BMWType { get; init; }
        public override CarMarks CarMarks => CarMarks.BMW;
        public override object Clone()
        {
            return new BMW() { Name = Name, Weight = Weight, BMWType=BMWType, GasMileage = GasMileage };
        }
    }
}
