using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    abstract class Air : Vehicles
    {
        public override int NumberOfDoors { get; set; } = 3;
        public override bool MovesBackward { get; set; } = false;

        public virtual bool IsAFlock(int numOfAirVehicles)
        {
            if (numOfAirVehicles > 0)
            {
                return true;
            }
            return false;
        }
    }
}
