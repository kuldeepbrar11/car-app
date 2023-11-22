using System;
using System.Diagnostics;
using System.Reflection;

namespace Car
{
    public class Car
    {
        public int year;
        public string manufacturer;
        public string model;
        public double price;
        public bool isDriveable;

        public Car(int year, string manufacturer, string model, double price, bool isDrivable)
        {
            this.year = year;
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.isDriveable = isDrivable;

        }

        public override string ToString()
        {
            string drivableStatus = isDriveable ? "Driveable" : "Not Driveable";
            return $"Make of car is {year}, manufactured by {manufacturer}, Model is {model}, Can this car be driven? {isDriveable}, it's price is {price}";
        }
    }
}


