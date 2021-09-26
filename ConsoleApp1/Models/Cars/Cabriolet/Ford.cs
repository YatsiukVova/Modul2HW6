using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Models.Car.Cabriolet
{
   public class Ford : Cabriolet
    {
        public FordType FordType { get; init; }
        public override CarMarks CarMarks => CarMarks.Ford;
        public override object Clone()
        {
            return new Ford() { Name = Name, Weight = Weight, FordType = FordType, GasMileage = GasMileage };
        }
    }
}
