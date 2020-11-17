using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Make = "Ford";
        public string Year = "2014";
        public string Model = "Focus";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Now driving our vehicle");
        }

    }
}
