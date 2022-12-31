using System;
using System.Runtime.ConstrainedExecution;

namespace ConsoleUI
{
	public class Car : Vehicle
    {
        //Constructor
        public Car()
        {
        }

        //Car specific property
        public bool HasTrunk { get; set; } = true;

        //Stubbed out method
        public override void DriveAbstract()
        {
            Console.WriteLine($"This car is in drive."); 
        }

    }
}

