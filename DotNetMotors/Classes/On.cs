using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public abstract class On : Land
    {
        public override int NumberOfWheeles { get; set; } = 4;
        public override int NumberOfDoors { get; set; } = 4;
        public virtual int Speed { get; set; } = 80;


    }
}
