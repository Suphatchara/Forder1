using System;

namespace Constructor
{

    public class Vehicle
    {
        private string _registrationNumber;

        private readonly string _registationNumber;
        // public Vehicle()
        //{
        //Console.WriteLine("Vehicle is being initialized.");
        //}

        public Vehicle(string registationNumber)
        {
            _registrationNumber = registationNumber;

            Console.WriteLine("vehicle is being initialized. {0}", registationNumber);


        }

    }



}
