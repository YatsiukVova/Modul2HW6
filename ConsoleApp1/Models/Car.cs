using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Models
{
  public abstract class Car : ICloneable
    {
        public string Name { get; init; }
        public double Weight { get; init; }
        public double  GasMileage { get; init; }
        public abstract bool IsHasRoof { get; }
        public override CarMarks CarMarks { get; }


        public abstract object Clone();
    }
}
