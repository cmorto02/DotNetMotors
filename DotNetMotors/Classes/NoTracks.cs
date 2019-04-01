using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class NoTracks : On
    {
        public override bool CarriesPeople { get; set; } = true;
        public override bool RequiresLiscense { get; set; } = true;

        public override void Honks()
        {
            Console.WriteLine("Im late for work");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Click, the battery is dead!");
        }
        
    }
}
