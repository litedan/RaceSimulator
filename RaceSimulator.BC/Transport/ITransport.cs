using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.BC.Transport
{
    public interface ITransport
    {
        double Speed { get; }
        string TypeName { get; }
        double FindTime(double distance);
    }
}
