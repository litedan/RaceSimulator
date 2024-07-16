using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.BC.Transport.GroundTypes
{
    public class MagicalBoots : GroundTransports
    {
        public MagicalBoots() 
        {
            Speed = 6.0;
            TypeName = "MagicalBoots";
            TimeTillRest = 60;
        }

        protected override double FindRestDuration(int ResCount) => ResCount == 1 ? 10 : 5 + FindRestDuration(ResCount--);
        
    }
}
