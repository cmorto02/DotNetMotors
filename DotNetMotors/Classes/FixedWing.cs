using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public abstract class FixedWing : Air
    {
        public override int NumberOfWheeles { get; set; } = 3;
        public override void TurnOn()
        {
            Console.WriteLine("This is your captain speaking, we are in for a bumpy ride");
        }
        public override bool Flies()
        {
            Console.WriteLine("Falling with style!");
            return true;
        }

        
    }
}
