using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class Under : Land, INotClaustrophobic
    {
        public override bool CarriesPeople { get; set; } = false;
        public override bool RequiresLiscense { get; set; } = true;
        public override int NumberOfWheeles { get; set; } = 20;
        public override int NumberOfDoors { get; set; } = 2;

        public override void Honks()
        {
            Console.WriteLine("No honks on a boring machine");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Get the drill ready!");
        }

        bool INotClaustrophobic.NotClaustrophobic()
        {
            Console.WriteLine("Those working undergroound should not be claustrophobic");
            return true;
        }
    }
}
