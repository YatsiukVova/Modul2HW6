using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using ConsoleApp1.Models.Cars;
using ConsoleApp1.Providers.Abstractions;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Providers
{
    class CarProvider : ICarProvider
    {
        private readonly Car[] _cars;

        public CarProvider()
        {
            _cars = new Car[]
            {
                new Ford { Name = "Car №1", Weight = 1500, FordType = FordType.K150, GasMileage = 2.3 },
                new Citroen { Name = "Car №2", Weight = 1100, CitroenType = CitroenType.Find, GasMileag = 2.1 },
                new Lada { Name = "Car №3", Weight = 900, LadaType = LadaType.Shoxa, GasMileage = 1.8 },
                new Lada { Name = "Car №4", Weight = 975, LadaType = LadaType.Devyatka, GasMileage = 2 },
                new Lanos { Name = "Car №5", Weight = 1300, LanosType = LanosType.Katafalk, GasMileage = 2.5 },
                new BWM { Name = "Car №6", Weight = 2000, BMWType = BMWType.A260, GasMileage = 2.8 },
                new MercedesBenz { Name = "Car №7", Weight = 1400, MercedesType = MercedesType.GT, GasMileage = 3 },
            };
        }

        public Car[] Cars
        {
            get
            {
                var animals = new Car[_cars.Length];
                for (var i = 0; i < _cars.Length; i++)
                {
                    animals[i] = _cars[i].Clone() as Car;
                }

                return animals;
            }
        }
    }
}
