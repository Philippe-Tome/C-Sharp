using System;

namespace _4._2_constructors_code_along
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialised. {0}", registrationNumber);
        }
    }
}
