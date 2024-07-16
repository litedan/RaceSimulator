using RaceSimulator.BC.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.BC.Race
{
    public class GroundTransportsRace : Race<GroundTransports>
    {
        public GroundTransportsRace(List<GroundTransports> list , double distance) : base(list, distance) { }
        public GroundTransportsRace(double distance) : base(distance) { }

        protected override string Type { get => "Ground"; }
    }
}
