using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class Tracks : On, IAdvancedTraining
    {
        public override int NumberOfWheeles { get; set; } = 40;
        public override int Speed { get; set; } = 40;

        public override void Honks()
        {
            Console.WriteLine("Get off the tracks!!!! HOOOOOOOOOOOOOONK!");
        }
        public override bool CarriesPeople { get; set; } = true;

        public override bool RequiresLiscense { get; set; } = true;

        public override void TurnOn()
        {
            Console.WriteLine("AAAAaaaaaalllll AAABBBOOOOOAAARRRRDDDDD!");
        }
        public virtual bool Derail()
        {
            if (Speed>50)
            {
                return true;
            }
            return false;
        }

        public void CertRequired()
        {
            Console.WriteLine("Engineers require advanced certification");
        }
    }
}
