using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.BC.Transport.AirTypes
{
    public class Mortar : AirTransports
    {
        public Mortar() 
        {
            Speed = 8.0;
            TypeName = "Mortar";
        }

        protected override double FindReducedDistance(double distance)
            => distance - distance * 6 / 100;
        
    }
}
