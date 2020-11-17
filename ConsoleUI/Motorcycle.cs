using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Now driving our abstract motorcycle");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Now driving our virtual motorcycle");
        }

        public bool HasSideCar;

        public Motorcycle(string make, string year, string model, bool sideCar)
        {
            HasSideCar = sideCar;
            this.Make = make;
            this.Year = year;
            this.Model = model;
        }
    }
}
