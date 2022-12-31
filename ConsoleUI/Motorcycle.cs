using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
        //Constructor
        public Motorcycle()
        {
        }

        //Motorcycle specific property
        public bool HasSideCart { get; set; } = false;

        //Stubbed out method
        public override void DriveAbstract()
        {
            Console.WriteLine($"This motorcycle is in drive!"); 
        }

        //Unique Virtual Method - Override of the original virtual method in the Vehicle class.
        public override void DriveVirtual()
        {
            Console.WriteLine($"I like to be different."); 
        }
    }
}

