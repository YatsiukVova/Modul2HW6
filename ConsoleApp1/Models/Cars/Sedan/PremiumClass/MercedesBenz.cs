using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Models.Car.Sedan.PremiumClass
{
   public class MercedesBenz : PremiumClass
    {
        public MercedesType MercedesType { get; init; }
        public override CarMarks CarMarks => CarMarks.Mersedes_Benz;
        public override object Clone()
        {
            return new MercedesBenz() { Name = Name, Weight = Weight, MercedesType=MercedesType, GasMileage = GasMileage };
        }
    }
}
