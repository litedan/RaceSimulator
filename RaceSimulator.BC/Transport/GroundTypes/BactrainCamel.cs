using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.BC.Transport.GroundTypes
{
    public class BactrainCamel : GroundTransports
    {
        public BactrainCamel() 
        {
            Speed = 10.0;
            TypeName = "BactrainCamel";
            TimeTillRest = 30;
        }

        protected override double FindRestDuration(int ResCount)
            => (ResCount == 1) ? 5 : 8 + FindRestDuration(--ResCount);
      
    }
}
