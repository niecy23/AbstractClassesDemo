using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * DONE follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle - DONE
             * The vehicle class shall have three string properties Year, Make, and Model - DONE
             * Set the defaults to something generic in the Vehicle class - DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation - DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. - DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - DONE
             * Provide the implementations for the abstract methods - DONE
             * Only in the Motorcycle class will you override the virtual drive method - DONE
            */

            // Create a list of Vehicle called vehicles - DONE

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes - DONE
             * 
             * Set the properties with object initializer syntax - DONE
             */

            Car Sedan = new Car() {Make = "Honda", Model = "Civic", Year = 2000 };

            Motorcycle Chopper = new Motorcycle() { HasSideCart = true, Make = "Harley Davidson", Model = "Road King", Year = 2012 };

            Vehicle SUV = new Car() { Make = "Jeep", Model = "Wrangler", Year = 2020, };

            Vehicle Truck = new Car() {HasTrunk = false, Make = "Dodge", Model = "Ram", Year = 2022 };


            /*
             * Add the 4 vehicles to the list - DONE
             * Using a foreach loop iterate over each of the properties - DONE
             */

            vehicles.Add(Sedan);
            vehicles.Add(Chopper);
            vehicles.Add(SUV);
            vehicles.Add(Truck);

            foreach (var car in vehicles)
            {
                Console.WriteLine($"Make: {car.Make}, Model: {car.Model}. Year: {car. Year}");
                car.DriveAbstract();
                car.DriveVirtual();
                Console.WriteLine("---------"); 
            }

            // Call each of the drive methods for one car and one motorcycle - DONE


            #endregion            
            Console.ReadLine();
        }
    }
}
