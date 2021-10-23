using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Car("Red","WV");
            Console.WriteLine(car);
            ICar superCar = new CarWithAmbulanceSignal(car, "ViU ViU ViU ViU ViU");
            Console.WriteLine(superCar);
            Console.ReadKey();
        }
    }
}
