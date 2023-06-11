using System;
using System.Diagnostics;
using System.Reflection;

public class Car
{
    private int year;
    private string manufacturer;
    private string model;
    private bool isDrivable;
    private double price;

    public Car(int year, string manufacturer, string model, bool isDrivable, double price)
    {
        this.year = year;
        this.manufacturer = manufacturer;
        this.model = model;
        this.isDrivable = isDrivable;
        this.price = price;
    }

    public override string ToString()
    {
        return $"Year: {year}, Manufacturer: {manufacturer}, Model: {model}, Is Drivable: {isDrivable}, Price: {price:C}"; ;
    }
}


