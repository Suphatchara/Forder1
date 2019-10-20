using System;

namespace Constructor
{
    public class Car : Vehicle
    {
        private static string registationNumber;

        public Car(string registrationNumber)
            : base(registationNumber)
        {
            Console.WriteLine("Car is being initialized.{0},registrationNumber");
        }
    }



}
