using System;
namespace CarDemoApp
{
        public class Car
        {
            public string Model { get; set; }
            public double KilometersPerLitre { get; set; }

            public Car(string model, double kilometersPerLitre)
            {
                Model = model;
                KilometersPerLitre = kilometersPerLitre;
            }

            public Car(string model)
            {
                Model = model;
                KilometersPerLitre = 15;
            }

            public static Car operator ++(Car car)
            {
                car.KilometersPerLitre++;
                return car;
            }
        }
}

