using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public abstract class Air : Vehicles, IAdvancedTraining, INotClaustrophobic
    {
        public override int NumberOfDoors { get; set; } = 3;
        public virtual bool RequiresCaptain { get; set; } = true;
        


        public virtual bool IsAFlock(int numOfAirVehicles)
        {
            if (numOfAirVehicles > 0)
            {
                return true;
            }
            return false;
        }

        public abstract bool Flies();

        public bool CertRequired()
        {
            Console.WriteLine("Pilots require advanced certifivation");
            return true;
        }

        public bool NotClaustrophobic()
        {
            Console.WriteLine("Those working in tight spaces should not be claustrophobic");
            return true;
        }
        
    }
}
