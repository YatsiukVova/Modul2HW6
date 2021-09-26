using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Models.Car.Sedan.EconomClass
{
   public class Lada : EconomClass
    {
        public LadaType LadaType { get; init; }
        public override CarMarks CarMarks => CarMarks.Lada;
        public override object Clone()
        {
            return new Lada() { Name = Name, Weight = Weight, LadaType=LadaType, GasMileage = GasMileage };
        }
    }
}
