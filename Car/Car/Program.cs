class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car(2022, "Toyota", "Camry", true,25000.50);
        Car car2 = new Car(2021, "Honda", "Civic",true, 22000.75);
        Car car3 = new Car(2023, "Ford", "Mustang",true, 35000.20);
        Car car4 = new Car(2020, "Chevrolet", "Corvette",false, 60000.90);

        Console.WriteLine(car1.ToString());
        Console.WriteLine(car2.ToString());
        Console.WriteLine(car3.ToString());
        Console.WriteLine(car4.ToString());
    }
}