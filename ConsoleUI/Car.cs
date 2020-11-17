using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk;

        public override void DriveAbstract()
        {
            Console.WriteLine("Now driving our abstract car");
        }

        public Car(string make, string year, string model, bool trunk)
        {
            HasTrunk = trunk;
            this.Make = make;
            this.Year = year;
            this.Model = model;
        }

    }
}
