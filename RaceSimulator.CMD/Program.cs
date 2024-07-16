using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceSimulator.BC;
using RaceSimulator.BC.Race;
using RaceSimulator.BC.Transport.AirTypes;
using RaceSimulator.BC.Transport.GroundTypes;


namespace RaceSimulator.CMD
{
    public class Program
    {
        static void Main(string[] args)
        {

            var fastCamel = new FastCamel();
            var bactrianCamel = new BactrainCamel();
            var centaur = new Centaur();
            var boots = new MagicalBoots();
            var broom = new Broomstick();
            var carpet = new MagicCarpet();
            var mortar = new Mortar();

            var allRace = new AllTransportsRace(1000);
            allRace.AddTransport(fastCamel);
            allRace.AddTransport(bactrianCamel);
            allRace.AddTransport(centaur);
            allRace.AddTransport(boots);
            allRace.AddTransport(broom);
            allRace.AddTransport(carpet);
            allRace.AddTransport(mortar);
            allRace.PrintWinner();

            var airRace = new AirTransportsRace(1000);
            airRace.AddTransport(mortar);
            airRace.AddTransport(broom);
            airRace.AddTransport(carpet);
            airRace.PrintWinner();

            var groundRace = new GroundTransportsRace(1000);
            groundRace.AddTransport(bactrianCamel);
            groundRace.AddTransport(centaur);
            groundRace.AddTransport(boots);
            groundRace.PrintWinner();
        }
    }
}
