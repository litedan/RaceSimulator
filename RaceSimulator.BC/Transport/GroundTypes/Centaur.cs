using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.BC.Transport.GroundTypes
{
    public class Centaur : GroundTransports
    {
        public Centaur()
        {
            Speed = 15.0;
            TypeName = "Centaur";
            TimeTillRest = 8;
        }
        protected override double FindRestDuration(int ResCount) => (ResCount == 1) ? 2 : 2 + FindRestDuration(ResCount--);    
        
    }
}
