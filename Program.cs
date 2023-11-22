using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Car;

class Program
{
    static void Main()
    {
        Car car1 = new Car(2014, "Honda", "Amaze", 15000, true);
        Car car2 = new Car(2018, "Toyota", "Camry", 25000, true);
        Car car3 = new Car(2020, "Ford", "Mustang", 40000, true);
        Car car4 = new Car(2010, "Honda", "City", 8000, false);

        Console.WriteLine(car1);
        Console.WriteLine(car2);
        Console.WriteLine(car3);
        Console.WriteLine(car4);
    }
}

