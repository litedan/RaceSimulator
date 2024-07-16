using RaceSimulator.BC.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.BC.Race
{
    public class AllTransportsRace : Race<ITransport>
    {
        public AllTransportsRace(List<ITransport> tranpportList, double distance) : base(tranpportList, distance) { }
        public AllTransportsRace(double distance) : base(distance) { }

        protected override string Type { get => "common"; }
    }
}
