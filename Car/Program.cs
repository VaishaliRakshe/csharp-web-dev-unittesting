using System;

namespace CarNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Honda", "Civic", 22, 39.64);
            Console.WriteLine(car.Make + " - " + car.Model);
        }
    }
}
