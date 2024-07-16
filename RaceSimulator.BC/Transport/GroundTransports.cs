using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.BC.Transport
{
    public abstract class GroundTransports : ITransport
    {
        public double Speed { get; set; }
        public string TypeName { get; set; }

        public double FindTime(double distance)
        {
            int ResCount = Convert.ToInt16(Math.Floor(distance / (Speed * TimeTillRest)));
            return distance / Speed + FindRestDuration(ResCount);
        }

        protected int TimeTillRest { get; set; }
        protected abstract double FindRestDuration(int ResCount);
    }
}
