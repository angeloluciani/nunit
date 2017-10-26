using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitCalculatorN
{

    /*
 I= V/R   V=6
          R=3    
          I=2
     */

    public class CircuitCalculator
    {
        const int v = 6;
        const int i = 2;
        const int r = 3;

        public decimal GetResistence()
        {
            return v/i;

        }

        public decimal GetIntensity()
        {
            return v/r;

        }

        public decimal GetVoltage()
        {
            return r * i;

        }

    }
}
