using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		//Properties
		public int Year { get; set; } = 1;
		public string Make { get; set; } = "Default Make";
		public string Model { get; set; } = "Default Model";
	

		//Stubbed out method
		public abstract void DriveAbstract();

		//Any class that inherits has the option to override this method.
		public virtual void DriveVirtual()
		{
			Console.WriteLine($"Drive Virtual"); 
		}

	}
}

