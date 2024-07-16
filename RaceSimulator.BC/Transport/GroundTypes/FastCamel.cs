using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.BC.Transport.GroundTypes
{
    public class FastCamel : GroundTransports
    {
        public FastCamel() 
        {
            Speed = 40.0;
            TypeName = "Camel";
            TimeTillRest = 10;
        }

        protected override double FindRestDuration(int ResCount)
        {
            if (ResCount == 1)
            {
                return 5;
            }
            else if (ResCount == 2)
            {
                return 6.5 + FindRestDuration(--ResCount);
            }
            else
            {
                return 8 + FindRestDuration(ResCount - 1);
            }
        }
    }
}
