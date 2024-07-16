using RaceSimulator.BC.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator.BC.Race
{
    public abstract class Race<T> where T : ITransport
    {
        private List<T> _transportList;
        protected abstract string Type { get; }
        private double Distance { get; }

        protected Race(List<T> transportsList, double distance)
        {
            _transportList = transportsList;
            Distance = distance;
        }

        protected Race(double distance)
        {
            _transportList = new List<T>();
            Distance = distance;
        }

        public void AddTransport(T transport)
        {
            if(! _transportList.Contains(transport))
            {
                _transportList.Add(transport);
            }
        }

        private string GetWinner()
        {
            if( _transportList.Count <= 1)
            {
                return "None";
            }
            return _transportList.Select(v => new
            {
                v.TypeName, Time = v.FindTime(Distance) 
            }).OrderBy(v => v.Time).First().TypeName;
        }

        public void PrintWinner()
        {
            var winner = GetWinner();
            if( winner == "None")
            {
                Console.WriteLine("The race cannot be started with 1 or less participants.");
            }
            else
            {
                Console.WriteLine("In {0} {1} race the winner is {2}.", Type, Distance, winner);
            }
        }

    }
}
