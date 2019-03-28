using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    abstract class Vehicles
    {
        public abstract bool RequiresLiscense { get; set; }
        public abstract int PriceUpperEnd { get; set; }
        public abstract int PriceLowerEnd { get; set; }
        public abstract int NumberOfWheeles { get; set; }
        public abstract bool MovesForward { get; set; }
        public abstract bool MovesBackward { get; set; }
        public abstract int NumberOfDoors { get; set; }

        public abstract void FillWithGas();
        public abstract void TurnOn();

    }
}
