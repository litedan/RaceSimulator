using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.BC.Transport.AirTypes
{
    public class Broomstick : AirTransports
    {
        public Broomstick() 
        {
            Speed = 20.0;
            TypeName = "Broomstick";
        }

        protected override double FindReducedDistance(double distance)
            => distance - (distance * Math.Floor(distance / 1000) / 100);
        
    }
}
