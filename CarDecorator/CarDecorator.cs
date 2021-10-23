using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDecorator
{
    public abstract class CarDecorator : ICar
    {
        protected ICar car;
        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public virtual string Color { get => car.Color; }

        public virtual string CarBrand { get => car.CarBrand; }
        public virtual string Beep { get => car.Beep; }
        public override string ToString()
        {
            return $"Car Brand {CarBrand} Color {Color} {Beep}";
        }
    }
}
