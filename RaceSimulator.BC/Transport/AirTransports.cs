using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.BC.Transport
{
    public abstract class AirTransports : ITransport
    {
        public double Speed { get; set; }
        public string TypeName { get; set; }

        public double FindTime(double distance) => FindReducedDistance(distance) / Speed;
        
        protected abstract double FindReducedDistance(double distance);
    }
}
