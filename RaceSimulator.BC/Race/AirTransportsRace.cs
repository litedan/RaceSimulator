using RaceSimulator.BC.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.BC.Race
{
    public class AirTransportsRace : Race<AirTransports>
    {
        public AirTransportsRace(List<AirTransports> transportsList, double distance) : base(transportsList, distance) { }
        public AirTransportsRace(double distance) : base(distance) { }

        protected override string Type { get => "air"; }
    }
}
