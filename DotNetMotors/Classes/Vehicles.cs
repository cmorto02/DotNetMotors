using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public abstract class Vehicles
    {
        public abstract bool RequiresLiscense { get; set; }
        public abstract int NumberOfWheeles { get; set; }
        public abstract int NumberOfDoors { get; set; }

        public abstract void TurnOn();

    }
}
