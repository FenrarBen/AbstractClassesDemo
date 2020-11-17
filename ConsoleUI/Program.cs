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
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car car = new Car("ford", "2014", "focus", true);
            Motorcycle moto = new Motorcycle("Kowasaki", "1994", "Ninja", true);
            Vehicle carV = new Car("Chevy", "2000", "Comaro", false);
            Vehicle motoV = new Motorcycle("Dunno", "2020", "Wacky", false);


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car);
            vehicles.Add(moto);
            vehicles.Add(carV);
            vehicles.Add(motoV);
            foreach (var cars in vehicles)
            {
                Console.WriteLine($"{cars.Year}\t{cars.Make}\t{cars.Model}");

            }

            // Call each of the drive methods for one car and one motorcycle
            Console.WriteLine();
            foreach (var cars in vehicles)
            {
                cars.DriveAbstract();
                if (true)
                {
                    cars.DriveVirtual();
                }
            }

            #endregion            
            Console.ReadLine();
        }
    }
}
