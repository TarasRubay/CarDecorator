using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDecorator
{
    public interface ICar
    {
        string Color { get; }
        string CarBrand { get; }
        string Beep { get; }
        
    }
}
