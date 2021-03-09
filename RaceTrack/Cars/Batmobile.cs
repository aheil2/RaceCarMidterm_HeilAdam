using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Batmobile : RaceCar
    { 
        public Batmobile()
        {
            Name = "Batmobile";
            TopSpeed = 101;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} appears out of nowhere!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} screeches to a halt!");
            base.Brake();
        }
        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} engine stops.");
        }
    }
}
