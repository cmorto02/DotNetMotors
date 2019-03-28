using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public abstract class Land : Vehicles
    {
        public abstract bool CarriesPeople { get; set; }

        public abstract void Honks();
    }
}
