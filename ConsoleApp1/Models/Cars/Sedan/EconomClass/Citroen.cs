using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Models.Car.Sedan.EconomClass
{
   public class Citroen : EconomClass
    {
        public CitroenType CitroenType { get; init; }
        public override CarMarks CarMarks => CarMarks.Citroen;
        public override object Clone()
        {
            return new Citroen() { Name = Name, Weight = Weight, CitroenType = CitroenType, GasMileage = GasMileage };
        }
    }
}
