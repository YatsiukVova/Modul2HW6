using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public abstract class Cabriolet : Car
    {
        public override bool IsHasRoof => false;
    }
}
