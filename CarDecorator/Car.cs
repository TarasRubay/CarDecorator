using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDecorator
{
    class Car : ICar
    {
        public string Color { get; private set; }

        public string CarBrand { get; private set; }
        public string Beep { get; protected set; }
        public Car(string color,string car_brand)
        {
            Color = color;
            CarBrand = car_brand;
            Beep = "Beep";
        }
        public override string ToString()
        {
            return $"Car Brand {CarBrand} Color {Color} {Beep}";
        }

    }
}
