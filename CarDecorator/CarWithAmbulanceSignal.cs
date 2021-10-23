using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDecorator
{

    public class CarWithAmbulanceSignal : CarDecorator
    {
       public string BeepAmbulnce { get; private set; }
        public CarWithAmbulanceSignal(ICar car,string beepSignal): base(car)
        {
            BeepAmbulnce = beepSignal;
        }
        public override string Beep => base.Beep + BeepAmbulnce;

    }
}
