using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.BC.Transport.AirTypes
{
    public class MagicCarpet : AirTransports
    {
        public MagicCarpet() 
        {
            Speed = 10.0;
            TypeName = "MagicCarpet";
        }

        protected override double FindReducedDistance(double distance)
        {
            if(distance > 1000 && distance <= 5000)
            {
                return distance - distance * 3 / 100;
            }
            if(distance > 5000 && distance <= 10000)
            {
                return distance - distance * 10 / 100;
            }
            if(distance > 10000)
            {
                return distance - distance * 5 / 100;
            }
            return distance;
        }
    }
}
