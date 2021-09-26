using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Models.Car.Sedan.EconomClass
{
     public class Lanos : EconomClass
    {
        public LanosType LanosType { get; init; }
        public override CarMarks CarMarks => CarMarks.Lanos;
        public override object Clone()
        {
            return new Lanos() { Name = Name, Weight = Weight, LanosType=LanosType, GasMileage = GasMileage };
        }
    }
}
