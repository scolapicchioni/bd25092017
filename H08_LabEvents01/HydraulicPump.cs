using System;
using System.Collections.Generic;
using System.Text;

namespace H08_LabEvents01
{
    public class HydraulicPump : Pump
    {
        public override void Turn(NuclearReactor reactor) {
            if (reactor.Temperature > 100)
                reactor.Temperature-=10;
        }
    }
}
