using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class Jet : FixedWing
    {
        public override bool RequiresLiscense { get; set; } = true;
        public override bool IsAFlock(int numOfAirVehicles)
        {
            Console.WriteLine("A group of jets isnt a flock, its a gaggle.");
            return base.IsAFlock(numOfAirVehicles);
        }
    }
}
