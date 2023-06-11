using System;

namespace CarDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", 20);
            Car car2 = new Car("Honda");

            Console.WriteLine("Before incrementation:");
            Console.WriteLine($"Car 1: Model = {car1.Model}, KilometersPerLitre = {car1.KilometersPerLitre}");
            Console.WriteLine($"Car 2: Model = {car2.Model}, KilometersPerLitre = {car2.KilometersPerLitre}");

            car1++;
            car2++;

            Console.WriteLine("After incrementation:");
            Console.WriteLine($"Car 1: Model = {car1.Model}, KilometersPerLitre = {car1.KilometersPerLitre}");
            Console.WriteLine($"Car 2: Model = {car2.Model}, KilometersPerLitre = {car2.KilometersPerLitre}");
        }
    }
}

